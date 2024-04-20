using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;  // We need this line for uGUI to work.
public class LevelIndecator : MonoBehaviour
{
    static private Text _UI_TEXT;
    static private int _STAGE = 0;

    void Awake()
    {
        _UI_TEXT = GetComponent<Text>();
        STAGE = SceneManager.GetActiveScene().buildIndex - 1;
        PlayerPrefs.SetInt("Level", STAGE);
    }

    static public int STAGE
    {
        get { return _STAGE; }
        private set
        {
            _STAGE = value;
            PlayerPrefs.SetInt("Level", value);
            if (_UI_TEXT != null)
            {
                _UI_TEXT.text = " Level: " + value.ToString("#,0");
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
        
    }
}
