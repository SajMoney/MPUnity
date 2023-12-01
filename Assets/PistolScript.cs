using System;
using UnityEngine;
using System.Windows.Input;
using UnityEditor;

public class WeaponController : MonoBehaviour
{
    private Animator weaponAnimator;


    void Start()
    {
        weaponAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            weaponAnimator.SetBool("AIM", true);
            if(Input.GetMouseButton(0)) {
                weaponAnimator.SetBool("SHOOT", true);
            }
            else {
                weaponAnimator.SetBool("SHOOT", false);  
            }
        }
  
        else
        {
            weaponAnimator.SetBool("AIM", false);
            if(Input.GetMouseButton(0))
            {
                weaponAnimator.SetBool("SHOOT", true);
            }
            else
            {
                weaponAnimator.SetBool("SHOOT", false);
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            weaponAnimator.SetBool("RELOAD", true);
        }
        else
        {
            weaponAnimator.SetBool("RELOAD", false);
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            Destroy(gameObject);
        }


       
    }

}
