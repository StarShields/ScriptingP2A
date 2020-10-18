using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    [Header("Setup")]
    public Rigidbody projectile;
    public Transform barrelEnd;
    public AudioSource EnemyRocket;
   public float fireRate = 2f;
    float nextFire;
    //bool attacking = false;
    [Header("Recognition")]
    // int health = 100;
    public GameObject self;
    public GameObject itemCheck;
    public float vibeCheck;

    [Header("Other Settings")]
    public Transform player;
    Transform enemyTransform;

     void Start()
    {
        float nextFire = Time.time;
        float fireRate = 1f;
    }
    void Update()
    {

       this.transform.LookAt(player);
       vibeCheck = Vector3.Distance(self.transform.position, itemCheck.transform.position);


        if (vibeCheck < 50)
        {
            ShootEnemy();
        }

        void ShootEnemy()
        {
            if (Time.time > nextFire)
            {

                Debug.Log("enemy shooting");
                EnemyRocket.Play();
              Rigidbody projectileInstance;
              projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation);
              projectileInstance.AddForce(barrelEnd.forward * 750f);
                nextFire = Time.time + fireRate;
            }
        }
    }
    public void TakeDamage(int enemyDamageIntake)
    {
        float x = this.gameObject.transform.localScale.x;
        float y = this.gameObject.transform.localScale.y;
        float z = this.gameObject.transform.localScale.z;

        //  health -= enemyDamageIntake;
        //Debug.Log(health + "health remaining");

        transform.localScale = new Vector3(x / 2, y / 2, z / 2);

        if (x < 0.9)
        {
            Destroy(gameObject);
        }
    }

}