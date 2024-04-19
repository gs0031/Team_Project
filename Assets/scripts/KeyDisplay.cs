using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDisplay : MonoBehaviour
{
    public int DisplayVal = 0;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void placeholder()
    {
        //this is to be determined 
    }
    // Update is called once per frame
    void Update()
    {
        KeyDetection keyDetection = GameObject.FindObjectOfType<KeyDetection>();
        // Get the ScoreCounter component

        if (keyDetection != null)
        {
            // Check if the score field is set in ScoreCounter
            if (keyDetection.KeyValue != 0)
            {
                // Assign the score value
                DisplayVal = keyDetection.KeyValue;
            }
        }
        if (DisplayVal == 1)
        {
            placeholder();
        }
    }
}
