using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardVolume : MonoBehaviour
{
    public int damageTaken = 3;
    PlayerBase player;
    public void OnTriggerEnter(Collider  other)
    {
           other.gameObject.GetComponent<PlayerBase>();

       if (player != null)
        {
            player.TakeDamage(damageTaken);
        }
    }
}
