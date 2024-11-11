using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPowerUp : PowerUp, IPowerUp
{

    [SerializeField] private float damageToAdd = 1f;

    

    public override void ActivatePowerUp()
    {
        PlayerStats stats = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
        stats.AddDamage(damageToAdd);
        Destroy(gameObject);
    }

}
