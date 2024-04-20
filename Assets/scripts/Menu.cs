using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void On_StartButton()
    {
        SceneManager.LoadScene(1);
    }
}