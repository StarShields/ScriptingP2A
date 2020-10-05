using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject muzzleflash;
    public AudioSource laserSound;
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            muzzleflash.SetActive(true);
            laserSound.Play();
        }
        else{
            muzzleflash.SetActive(false);
          // laserSound.Pause
        }
    }
}
