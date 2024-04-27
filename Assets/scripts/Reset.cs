using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject Music;

    private void Start() => Music = GameObject.FindWithTag("Music");
    public void resetMusic()
    {
        Destroy(Music);
    }
}
