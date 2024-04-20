using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void On_RestartButton()
    {
        SceneManager.LoadScene("_Main_Menu");
    }
}
