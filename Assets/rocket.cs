using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
   
    void Update()
    {
        Destroy(gameObject, 3f);
        
    }

     void OnCollisionEnter(Collision collision)
    {
        
        Destroy(gameObject);
    }
}
