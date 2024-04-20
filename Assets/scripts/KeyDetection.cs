using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDetection : MonoBehaviour
{
        public int KeyValue1; // Initialize KeyValue to 0
        public int KeyValue;


        // OnTriggerEnter is called when the Collider other enters the trigger
        void OnTriggerEnter(Collider other)
        {
            // Check if the object that collided is tagged as "Character"
            if (other.CompareTag("Character"))
            {
                KeyValue1++; // Increment KeyValue by 1
                Debug.Log("Collision detected with: " + other.gameObject.name);
                KeyValue = KeyValue1;
            }
        }
    
    // Update is called once per frame
    void Update()
        {

        }
    }
