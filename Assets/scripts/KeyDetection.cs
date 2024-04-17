using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDetection : MonoBehaviour
{
    public int KeyValue = 0;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        GameObject collidedWith = collision.gameObject;


        if (collidedWith.CompareTag("Character"))
        {
            KeyValue = 1;
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
