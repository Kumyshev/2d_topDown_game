using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichingWeapon : MonoBehaviour
{

    public int itemsWeapon = 0;
    // Start is called before the first frame update


    void WeaponSelect()
    {
        int i = 0;

        foreach (Transform weapon in transform)
        {

            if (i == itemsWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;

        }

    }

    void Start()
    {
        WeaponSelect();
    }

    // Update is called once per frame
    void Update()
    {

        int previousSelectedWeapon = itemsWeapon;

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (itemsWeapon == 0)
            {
                itemsWeapon = 1;
            }
            else
                itemsWeapon = 0;
            
        }

        if (previousSelectedWeapon != itemsWeapon)
            WeaponSelect();
    }
}
