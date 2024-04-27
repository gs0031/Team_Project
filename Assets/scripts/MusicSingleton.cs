using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicSingleton : MonoBehaviour
{
    public GameObject music;
    public static MusicSingleton instance { get; private set; }

    void Awake()
    {
        DontDestroyOnLoad(music);
    }
}
