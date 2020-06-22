using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderHealth : Health
{
    public override bool Damage(float amount)
    {
        healthRemaining -= amount;
        if (healthRemaining <= 0)
        {
            Destroy(gameObject, 0.2f);
        }
        return true;
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
