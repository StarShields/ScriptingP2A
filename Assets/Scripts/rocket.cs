using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    public float lifetime;
    public float destroytime = 10f;
    void Update()
    {
        
            lifetime += Time.deltaTime;
            if (lifetime >= destroytime)
            {
                DestroyRocket();
            }
        
    }
    public void DestroyRocket()
        {
        Debug.Log("ROCKET IS BEING DESTROYED");
            Destroy(gameObject);
        
        }
    private void OnTriggerEnter(Collider other)
    {
        PlayerBase playerBase
            = other.gameObject.GetComponent<PlayerBase>();
        if(playerBase != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}