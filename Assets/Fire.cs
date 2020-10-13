using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] Camera cameraController;
    [SerializeField] Transform rayOrigin;
    [SerializeField] float shootDistance = 10f;
    [SerializeField] GameObject effect;
    [SerializeField] int weaponDamage = 20;
    public GameObject muzzleflash;
    public AudioSource laserSound;

    RaycastHit objectHit;
    void Update()
    {
        //   if (Input.GetButtonDown("Fire1")) {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
            muzzleflash.SetActive(true);
            laserSound.Play();
            Debug.Log("This part is working");
        }
        // if (Input.GetButtonUp("Fire1"))
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            muzzleflash.SetActive(false);
        }

        void Shoot()
        {
          //  RaycastHit hit;
            //calculate direction! 
           //if(Physics.Raycast(cameraController.transform.position, cameraController.transform.forward, out hit, shootDistance))
           // {
           //     Debug.Log(hit.transform.name);
           // }      
            Vector3 rayDirection = cameraController.transform.forward;
            //do raycast
                   Debug.DrawRay(rayOrigin.position, rayDirection * shootDistance, Color.blue, 1f);
           if (Physics.Raycast(rayOrigin.position, rayDirection, out objectHit, shootDistance)) {

           
               Debug.Log("you just hit " + objectHit.transform.name);
                effect.transform.position = objectHit.point;

                Enemy enemy = objectHit.transform.gameObject.GetComponent<Enemy>();
                if(enemy != null)
                {
                    enemy.TakeDamage(weaponDamage);
                }
          }
         else
           {
               Debug.Log("miss");
          }
        }
    }
}



