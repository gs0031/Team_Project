using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject DoorObject;
    public KeyDetection keyDetection;
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        GameObject collidedWith = collision.gameObject;
        keyDetection = collision.gameObject.GetComponent<KeyDetection>();

        // Get the ScoreCounter component
        if (keyDetection != null)
        {
            int keyValue = keyDetection.KeyValue1;
            // Check if the score field is set in ScoreCounter
            if (keyValue != 0)
            {
                // Assign the score va
                if (keyValue == 1)
                {
                    Scene currentScene = SceneManager.GetActiveScene();

                    // Get the index of the current scene
                    int currentSceneIndex = currentScene.buildIndex;

                    // Load the next scene
                    SceneManager.LoadScene(currentSceneIndex + 1);
                }
            }
        }
    }
}
