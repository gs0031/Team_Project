using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeBehavior : MonoBehaviour
{
    public float timerSet = 360;
    private static float timer = 360;
    public bool timerOn = true;
    public TextMeshProUGUI timeValue;

    void Start()
    {
        timer = timerSet; // Set timer back to initial value
        timerOn = true; // Start the timer again if it was stopped
        UpdateTimerText(timer); // Update the timer UI text

        if (PlayerPrefs.HasKey("timeValue") && SceneManager.GetActiveScene().buildIndex != 2)
        {
            timer = PlayerPrefs.GetFloat("timeValue");
        }

    }

    void Update()
    {
        if (timer >= 0 && timerOn)
        {
            timer -= (Time.deltaTime/2);
            PlayerPrefs.SetFloat("timeValue", timer);
            UpdateTimerText(timer);

            if (timer <= 0)
            {
                LoadSceneOnTimeout();
            }
        }
        else
        {
            timerOn = false;
        }
    }

    void UpdateTimerText(float remainingTime)
    {
        int min = Mathf.FloorToInt(remainingTime / 60);
        int secs = Mathf.FloorToInt(remainingTime % 60);
        timeValue.text = min.ToString("00") + ":" + secs.ToString("00");
    }

    void LoadSceneOnTimeout()
    {
        SceneManager.LoadScene("Game_Over");
    }
}

