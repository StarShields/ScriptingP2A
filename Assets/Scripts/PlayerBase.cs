using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBase : MonoBehaviour
{
    public float maxHealth = 50;
    public float currentHealth;
   
  
    public HealthBar healthBar;
    public GameObject deathtext;
    public AudioSource InjurySound;

    float damageTaken = 3f;
    
    float restoreAmount = 50f;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(float damageTaken)
    {
        InjurySound.Play();
        currentHealth -= damageTaken;
        healthBar.SetHealth(currentHealth);
        if (currentHealth < 1)
        {
            Debug.Log("died");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
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
            currentHealth = 50f;
        }
    }
}
