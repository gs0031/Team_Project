using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropen : MonoBehaviour
{
    public GameObject doorObject;

    public void Destroy()
    {
        doorObject.SetActive(false);
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        GameObject collidedWith = collision.gameObject;


        if (collidedWith.CompareTag("Character"))
        {
            // Load the next scene
            Destroy();
        }
    }
}
