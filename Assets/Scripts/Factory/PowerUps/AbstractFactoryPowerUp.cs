using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactoryPowerUp : MonoBehaviour
{
    public abstract PowerUp PowerUp { get; set; }
    public string powerUpTýpe;


    public abstract PowerUp CreatePowerUp(Vector2 position);
}
