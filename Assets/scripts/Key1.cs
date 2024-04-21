using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key1 : MonoBehaviour
{

    public Image imageToControl1;
    public Image imageToControl2;
    public Image imageToControl3;
    private void Start()
    {
        imageToControl1.enabled = false;
        imageToControl2.enabled = false;
        imageToControl3.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        int KeyFound = KeyDetection.KeyValue1;
        int Key1 = 1;
        int Key2 = 2;
        int Key3 = 3;

        if (KeyDetection.KeyValue1 == Key1)
        {
            // If the key is found, enable the image
            imageToControl1.enabled = true;
        }
        if (KeyDetection.KeyValue1 == Key2)
        {
            // If the key is found, enable the image
            imageToControl2.enabled = true;
        }
        if (KeyDetection.KeyValue1 == Key3)
        {
            // If the key is found, enable the image
            imageToControl3.enabled = true;
        }

    }
}

