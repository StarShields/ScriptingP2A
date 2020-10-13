using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBase : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject deathtext;
   // public GameObject DeathAnim;
   // [SerializeField] public Animator deathControl;
    int damageTaken = 3;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        //   deathControl.SetBool("isDead", false);
    }

    private void Update()
    {

    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;
        healthBar.SetHealth(currentHealth);
        if (currentHealth < 1)
        {
            Cursor.lockState = CursorLockMode.None;
            deathtext.SetActive(true);
            Time.timeScale = 0f;

        }

    }
}
