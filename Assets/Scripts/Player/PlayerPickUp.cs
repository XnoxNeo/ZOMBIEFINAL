using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{

    
   
    private void Start()
    {
        
        
    }

    private void EraseWeapon()
    {
        
        Shooting shooting = GetComponent<Shooting>();

        if(shooting.weapon != null)
        {
            
            shooting.weapon.DestroyWeapon();
        }

        shooting.weapon = null;

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag("Weapon"))
        {
            EraseWeapon();
            Debug.Log("Enterer weapon zone");
            BoxCollider2D boxCollider2D = collision.GetComponent<BoxCollider2D>();
            Rigidbody2D rigidbody2D = collision.GetComponent<Rigidbody2D>();

            boxCollider2D.enabled = false;
            

            IWeapon weapon = collision.GetComponent<IWeapon>();
            weapon.PickUp(transform);

        }

        if (collision.CompareTag("PowerUp"))
        {
            
            IPowerUp powerUp = collision.GetComponent<IPowerUp>();
            powerUp.PickUp();
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("VendingMachine"))
        {
            if(Input.GetKeyDown(KeyCode.E) && GameManager.Instance.score >= 100) 
            {
                VendingMachine vm = collision.GetComponent<VendingMachine>();
                vm.VendingMachineActivation();
                GameManager.Instance.score -= 100;
            }
        }


    }

}
