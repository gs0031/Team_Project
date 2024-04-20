using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // We need this line for uGUI to work.


public class Exit : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
    }
}
