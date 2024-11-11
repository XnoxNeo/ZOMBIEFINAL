using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : PowerUp, IPowerUp
{
    [SerializeField] private float speedToAdd = 0.1f;

    

    public override void ActivatePowerUp()
    {
        PlayerStats stats = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
        stats.AddSpeed(speedToAdd);
        Destroy(gameObject);
    }
}
