using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject doorObject;
    public void Destroy()
    {
        doorObject.SetActive(false);
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        Debug.Log("KeyValue " + KeyDetection.KeyValue1);
        Debug.Log("Keys Needed " + DungeonGenerator.KeysNeeded);

        GameObject collidedWith = collision.gameObject;


        if (collidedWith.CompareTag("Character") && KeyDetection.KeyValue1 == DungeonGenerator.KeysNeeded)
        {
            // Load the next scene
            Destroy();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Update()
    {
        int KeyFound = KeyDetection.KeyValue1;
        int KeysNeeded = DungeonGenerator.KeysNeeded;
    }
}
