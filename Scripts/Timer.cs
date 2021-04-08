using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    private float timeLeft = 30f;
    
    void Update()
    {
        timeLeft -= Time.deltaTime;

        timeText.text = "Таймер: " + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            //Application.LoadLevel("gameOver");
        }

    }
}
