using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    public PlayerMovement playerMovement;
    public ScriptableHealth health;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        healthRemaining = health.health;
        maxHealth = health.maxHealth;
    }

    public override bool Damage(float amount)
    {
        if (!playerMovement.isAttacking)
        {
            healthRemaining -= amount;
            health.health -= amount;
            if (healthRemaining <= 0)
            {
                //EventManager.Instance.PlayerDeath();
            }
            return true;
        } else
        {
            return false;
        }
    }

    public override void Restore(float amount)
    {
        healthRemaining += amount;
        health.health += amount;
        if (healthRemaining > maxHealth)
        {
            healthRemaining = maxHealth;
        }
    }
}
