using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBase : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject DeathAnim;
    [SerializeField] public Animator deathControl;
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
            DeathAnim.SetActive(true);
            deathControl.SetBool("isDead", true);

        }

    }
}
