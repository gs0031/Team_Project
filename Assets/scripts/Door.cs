using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject doorObject;
    public AudioClip doorSound; // AudioClip to play when the door is triggered
    private AudioSource audioSource; // AudioSource component

    void Start()
    {
        // Get the AudioSource component from this GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null) // Check if AudioSource is attached
        {
            Debug.LogWarning("not found");
        }
    }

    public void Destroy()
    {
        doorObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        Debug.Log("KeyValue " + KeyDetection.KeyValue1);
        Debug.Log("Keys Needed " + DungeonGenerator.KeysNeeded);

        GameObject collidedWith = collision.gameObject;

        if (collidedWith.CompareTag("Character") && KeyDetection.KeyValue1 == DungeonGenerator.KeysNeeded)
        {
            // Play the door sound if all conditions are met
            if (audioSource != null && doorSound != null)
            {
                audioSource.PlayOneShot(doorSound);
            }

            // Load the next scene
            Destroy();
        }
    }
}