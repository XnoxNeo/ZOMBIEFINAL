using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Weapon")]
    [SerializeField] public IWeapon weapon;
    private Transform playerTransform;
    public float weaponRecharge;
    private float timer;

    PlayerStats playerStats;
    private void Start()
    {
        playerStats = GetComponent<PlayerStats>();
        playerTransform = GetComponent<Transform>();
    }

    
    private void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetButton("Fire1")&&timer > playerStats.PlayerReload) 
        {
            timer = 0;
            weapon?.Shoot();
        }
    }

    
   
}
