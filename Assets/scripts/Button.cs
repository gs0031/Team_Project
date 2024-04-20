using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  // We need this line for uGUI to work.
using TMPro;

public class Button : MonoBehaviour
{
    public void LoadNextScene2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ContinueButton()
    {
        SceneManager.LoadScene("_Main_Menu");
    }


    // Quit Button
    public void ExitButton()
    {
        Application.Quit();
    }
}
