using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public TextMeshProUGUI bulletsText;

    private void Update()
    {
        bulletsText.text = "Патронов: " + PlayerPrefs.GetInt("AllBullets", 0).ToString(); 
    }



}
