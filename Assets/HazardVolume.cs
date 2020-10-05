using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardVolume : MonoBehaviour
{
  
    public void OnTriggerEnter(Collider other)
    {
        PlayerMovement PlayerMovement;
            other.gameObject.GetComponent<PlayerMovement>();

      //  if (PlayerMovement != null)
        {
         //S   PlayerMovement.Kill();
        }
    }
}
