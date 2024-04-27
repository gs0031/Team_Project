using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class sound : MonoBehaviour
{
    public GameObject soundObject;
    public AudioClip impact;
    AudioSource audioSource;
    float wait = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
    void OnTriggerEnter(Collider collision)
    {
        GameObject collidedWith = collision.gameObject;

        if (collision.gameObject.CompareTag("Character"))
            Debug.Log("hit " + gameObject);

        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(impact);
        }
        if (!soundObject.CompareTag("lockedAudio"))
        {
            Destroy(gameObject, wait);
        }
    }

    private void Update()
    {
        if (soundObject.CompareTag("lockedAudio") && KeyDetection.KeyValue1 == DungeonGenerator.KeysNeeded)
        {
            Destroy(gameObject);
        }
    }
}
