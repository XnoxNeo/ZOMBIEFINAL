using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public virtual void Move(Transform player, float speed)
    {

        Vector2 direction = (player.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);


    }
    public virtual void Attack(GameObject gameObject, int damage) 
    {
        HealthSystem healthSystem = gameObject.GetComponent<HealthSystem>();
        healthSystem.TakeDamage(damage);

    }
    


}
