using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsInfo : MonoBehaviour
{
    public TextMeshProUGUI PointsText;

    private int Points;


    private void Start()
    {
        PlayerPrefs.SetInt("AllPoints", 0);
        PlayerPrefs.SetInt("Points", 0);
    }


    private void Update()
    {
        Points = PlayerPrefs.GetInt("AllPoints", 0);

        PlayerPrefs.SetInt("Points", Points);

        PointsText.text = "Очки: " + PlayerPrefs.GetInt("AllPoints", 0).ToString();
        
    }
}
