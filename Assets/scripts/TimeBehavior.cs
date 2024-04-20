using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeBehavior : MonoBehaviour
{
    public float timer = 300;
    public bool timerOn = true;
    public TextMeshProUGUI timerText;

    void Start()
    {
        ResetTimer();
        if (PlayerPrefs.HasKey("timeValue"))
        {
            timer = PlayerPrefs.GetFloat("timeValue");
        }
    }

    void Update()
    {
        if (timer >= 0 && timerOn)
        {
            timer -= Time.deltaTime;
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

    public void ResetTimer()
    {
        timer = 300; // Set timer back to initial value
        timerOn = true; // Start the timer again if it was stopped
        UpdateTimerText(timer); // Update the timer UI text
    }

    void UpdateTimerText(float remainingTime)
    {
        int min = Mathf.FloorToInt(remainingTime / 60);
        int secs = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = min.ToString("00") + ":" + secs.ToString("00");
    }

    void LoadSceneOnTimeout()
    {
        SceneManager.LoadScene("Game_Over");
    }

    private void Awake()
    {
        ResetTimer();
    }
}

