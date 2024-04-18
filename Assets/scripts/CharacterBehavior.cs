using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController), typeof(Animator))]
public class CharacterBehavior : MonoBehaviour
{
    private CharacterController characterController;
    private Animator animator;

    [SerializeField]
    private float movementSpeed, rotationSpeed;

    private Vector3 movementDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calculate movement direction based on input
        Vector3 inputMovement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        if (verticalInput < 0f) // Moving backward
        {
            movementDirection = -transform.forward * movementSpeed * Time.deltaTime;
        }
        else // Moving forward or sideways
        {
            movementDirection = transform.forward * verticalInput * movementSpeed * Time.deltaTime;
        }

        // Rotate the character
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);

        // Move the character using the calculated movement
        characterController.Move(movementDirection);

        // Update animation based on movement input
        bool isRunning = verticalInput != 0f;
        animator.SetBool("isRunning", isRunning);
    }
}
