using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    public GameObject keyObject;
    public GameObject DestroyKey;
    public void Destroy()
    {
        keyObject.SetActive(false);
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        GameObject collidedWith = collision.gameObject;


        if (collidedWith.CompareTag("Character"))
        {
            // Load the next scene
            Destroy();
        }
    }
}
