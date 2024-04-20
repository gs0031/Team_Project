using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;  // We need this line for uGUI to work.

public class KeyIndecator : MonoBehaviour
{
    static private Text _UI_TEXT;
    static private int _STAGE;

    static public int STAGE
    {
        get { return _STAGE; }
        private set
        {
            _STAGE = value;
            PlayerPrefs.SetInt("Keys", value);
            if (_UI_TEXT != null)
            {
                _UI_TEXT.text = " Keys: " + value.ToString("#,0");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int KeyFound = KeyDetection.KeyValue1;
        int KeysNeeded = DungeonGenerator.KeysNeeded;

        _UI_TEXT = GetComponent<Text>();
        STAGE = KeyDetection.KeyValue1;
        PlayerPrefs.SetInt("Keys", STAGE);
    }
}
