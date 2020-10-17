using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] Camera cameraController;
    [SerializeField] Transform rayOrigin;
    [SerializeField] float shootDistance = 10f;
    [SerializeField] ParticleSystem effect;
    [SerializeField] int weaponDamage = 20;
    public GameObject shield;
    public Transform shieldDeployPoint;
    public GameObject muzzleflash;
    public AudioSource laserSound;
    public GameObject deployCursor;
    PlayerBase player;

    RaycastHit objectHit;
     void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            deployCursor.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("ShieldActivated");
            ShieldsUp();
            deployCursor.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
            muzzleflash.SetActive(true);
            laserSound.Play();
            Debug.Log("This part is working");
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            muzzleflash.SetActive(false);
        }

        void Shoot()
        {
           
            Vector3 rayDirection = cameraController.transform.forward;
            //do raycast
                   //Debug.DrawRay(rayOrigin.position, rayDirection * shootDistance, Color.blue, 1f);
           if (Physics.Raycast(rayOrigin.position, rayDirection, out objectHit, shootDistance)) {
               Debug.Log("you just hit " + objectHit.transform.name);
                effect.transform.position = objectHit.point;
                Enemy enemy = objectHit.transform.gameObject.GetComponent<Enemy>();
                if(enemy != null)
                {
                    enemy.TakeDamage(weaponDamage);
                    //EnemyDamaged.Play();
                }
          }
         else
           {
                Debug.Log("miss");
          }
        }
    }
     void ShieldsUp()
    {
        Instantiate(shield, shieldDeployPoint.position, shieldDeployPoint.rotation);  
    }
}



