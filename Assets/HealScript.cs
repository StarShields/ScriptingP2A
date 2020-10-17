using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealScript : MonoBehaviour
{
    public float lifetime;
    public float destroytime = 10f;
    public AudioSource HealSound;
    void Update()
    {

        lifetime += Time.deltaTime;
        if (lifetime >= destroytime)
        {
            DestroyShield();
        }

    }
    public void DestroyShield()
    {

        Debug.Log("Shield IS BEING DESTROYED");
        Destroy(gameObject);

    }
    private void OnTriggerEnter(Collider other)
    {
        HealSound.Play();
    }
    private void OnTriggerStay(Collider other)
    {
      
        PlayerBase player
            = other.gameObject.GetComponent<PlayerBase>();
        player.Heal();
    }
}
