﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    public int maxHealth = 100;
    int currentHealth;

    public HealthBar healthbar;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(currentHealth);
    }
    public void TakeDamage(int damage) {
        currentHealth -= damage;

        animator.SetTrigger("Take Damage");
        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0) {
            Die();
        }
    }

    void Die() {
        animator.SetBool("isDead", true);
        animator.SetTrigger("Die");
        GetComponent<Collider>().enabled = false;

        // Set script to off once enemy is dead
        this.enabled = false;


    }

}
