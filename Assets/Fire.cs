using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject muzzleflash;
    void Update()
    {
        if (Input.GetButton("Fire1")){
            muzzleflash.SetActive(true);
        }
        else{
            muzzleflash.SetActive(false);
        }
    }
}
