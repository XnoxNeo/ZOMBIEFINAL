using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    public float Speed => speed;

    [SerializeField] private float damageMultiplier = 1.0f;
    public float DamageMultiplier => damageMultiplier;


    public void AddDamage(float addValue)
    {
        damageMultiplier += addValue;
    }

    public void AddSpeed(float addValue)
    {
        speed += addValue;
    }



}
