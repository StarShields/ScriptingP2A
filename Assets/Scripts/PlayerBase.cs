using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBase : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
   
  
    public HealthBar healthBar;
    public GameObject deathtext;

    float damageTaken = 3f;
    
    float restoreAmount = 50f;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(float damageTaken)
    {
        currentHealth -= damageTaken;
        healthBar.SetHealth(currentHealth);
        if (currentHealth < 1)
        {
            Debug.Log("died");
            Cursor.lockState = CursorLockMode.None;
            deathtext.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Heal()
    {
        Debug.Log("restoring health...");


        currentHealth += restoreAmount  * Time.deltaTime;
        healthBar.SetHealth(currentHealth);
        if (currentHealth > maxHealth)
        {
            Debug.Log("Max health reached");
            currentHealth = 100f;
        }
    }
}
