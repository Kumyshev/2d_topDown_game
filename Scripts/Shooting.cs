using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform fire;
    public GameObject bullets;
    public float firePower = 10f;
    public int AllBullets = 100;


    private void Start()
    {
        PlayerPrefs.SetInt("AllBullets", AllBullets);
    }


    void shooting()
    {
        //Bullets bl = gameObject.AddComponent<Bullets>();
        //bl.MaxBullets(1);

        
        PlayerPrefs.SetInt("AllBullets", --AllBullets);


        GameObject bullet = Instantiate(bullets, fire.position, fire.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(fire.up * firePower, ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetButtonDown("Fire1"))
        {
            
            shooting();
        }

    }



    
}
