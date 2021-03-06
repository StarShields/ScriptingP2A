﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardVolume : MonoBehaviour
{
    public int damageTaken = 10;
    PlayerBase player;
    public void OnTriggerEnter(Collider  other)
    {
        PlayerBase player
          = other.gameObject.GetComponent<PlayerBase>();
        if (player != null)
        {
            player.TakeDamage(damageTaken);
        }
    }
}
