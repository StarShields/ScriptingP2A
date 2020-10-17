using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public LEVEL01CONTROLLER score;
    PlayerBase player;
   // public AudioSource goal;
    public ParticleSystem GoalEffect;
    public void OnTriggerEnter(Collider other)
    {

        PlayerBase player
          = other.gameObject.GetComponent<PlayerBase>();
        if (player != null)
        {
           score.IncreaseScore(1);
            //goal.Play();
            GoalEffect.Play();
        }

    }
}
