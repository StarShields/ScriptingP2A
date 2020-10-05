using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject player;
     int damageTaken = 3;

    void Start()
    {
        currentHealth = maxHealth;
       healthBar.SetMaxHealth(maxHealth);
    }
  
    public void TakeDamage(int damageTaken)
        {
            currentHealth -= damageTaken;
            healthBar.SetHealth(currentHealth);
        }
}
