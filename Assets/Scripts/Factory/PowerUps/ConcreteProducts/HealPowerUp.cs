using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPowerUp : PowerUp, IPowerUp
{
    [SerializeField] private int healValue = 20;

    

    public override void ActivatePowerUp()
    {
        HealthSystem stats = GameObject.FindWithTag("Player").GetComponent<HealthSystem>();
        stats.HealDamage(healValue);
        Destroy(gameObject);
    }
}
