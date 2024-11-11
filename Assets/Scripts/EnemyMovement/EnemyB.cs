using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyB : Enemy
{
    [Header("Stats")]
    [SerializeField] private EntityStats stats;

    private float speed;
    private float detectionRange;
    private int damage;
    private float scale;
    private HealthSystem healthSystem;

    [Header("Player Stats")]
    private Transform player;

    private void Start()
    {
        speed = stats.speed;

        detectionRange = stats.detectionRange;

        damage = stats.damage;

        scale = stats.scale;
        transform.localScale *= scale;


        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    private void Update()
    {
        if (player != null)
        {
            float distance = Vector2.Distance(transform.position, player.position);

            if (distance <= detectionRange)
            {
                Move(player, speed);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Attack(collision.gameObject, damage);
        }
    }
}
