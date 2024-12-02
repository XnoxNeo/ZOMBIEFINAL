using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRatePowerUp : PowerUp, IPowerUp
{
    [SerializeField] private float WeaponRateToAdd = 0.5f;



    public override void ActivatePowerUp()
    {
        PlayerStats stats = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
        stats.AddWeaponRate(WeaponRateToAdd);
        Destroy(gameObject);
    }
}
