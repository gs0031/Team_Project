using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int value = 0;
    public GameObject DoorObject;
    public GameObject DestroyDoor;
    public void Destroy()
    {
        DoorObject.SetActive(false);
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        GameObject collidedWith = collision.gameObject;

        KeyDetection keyDetection = GameObject.FindObjectOfType<KeyDetection>();

       
            // Get the ScoreCounter component

            if (keyDetection != null)
            {
                // Check if the score field is set in ScoreCounter
                if (keyDetection.KeyValue != 0)
                {
                    // Assign the score value
                    value = keyDetection.KeyValue;
                }
            }
        if (value == 1)
        {
            Destroy();
        }
    }


    // Start is called before the first frame update
    void Start()
        {
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
