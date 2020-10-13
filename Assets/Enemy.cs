using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    [Header("Setup")]
    public Rigidbody projectile;
    public Transform barrelEnd;
    [Header("Recognition")]
    // int health = 100;
    public GameObject self;
    public GameObject itemCheck;
    public float vibeCheck;
    [Header("Other Settings")]
    public Transform player;
    Transform enemyTransform;

   
    void Update()
    {

        vibeCheck = Vector3.Distance(self.transform.position, itemCheck.transform.position);
      this.transform.LookAt(player);
        if(vibeCheck < 50)
        {

            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation);
            projectileInstance.AddForce(barrelEnd.forward * 500f);


        }
    }
    public void TakeDamage(int enemyDamageIntake)
    {
        float x = this.gameObject.transform.localScale.x;
        float y = this.gameObject.transform.localScale.y;
        float z = this.gameObject.transform.localScale.z;

      //  health -= enemyDamageIntake;
        //Debug.Log(health + "health remaining");

        transform.localScale = new Vector3(x/2, y/2, z/2);

        if(x < 0.5)
        {
            Destroy(gameObject);
        }
    }
       
   
}
