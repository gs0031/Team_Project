using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void LoadNextScene2()
    {

        Scene currentScene = SceneManager.GetActiveScene();

        // Get the index of the current scene
        int currentSceneIndex = currentScene.buildIndex;

        // Load the next scene
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
