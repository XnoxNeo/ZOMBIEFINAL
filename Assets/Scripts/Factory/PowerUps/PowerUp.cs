using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour, IPowerUp
{
    public virtual void PickUp()
    {
        ActivatePowerUp();
    }

    public virtual void ActivatePowerUp()
    {

    }
}
