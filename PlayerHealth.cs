using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    public PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();    
    }

    public override bool Damage(float amount)
    {
        if (!playerMovement.isAttacking)
        {
            healthRemaining -= amount;
            if (healthRemaining <= 0)
            {
                EventManager.Instance.PlayerDeath();
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
        if (healthRemaining > maxHealth)
        {
            healthRemaining = maxHealth;
        }
    }
}
