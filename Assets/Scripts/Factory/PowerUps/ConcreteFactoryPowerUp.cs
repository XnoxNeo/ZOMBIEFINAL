using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteFactoryPowerUp : AbstractFactoryPowerUp
{
    [SerializeField] private PowerUp powerUp;
    public override PowerUp PowerUp { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override PowerUp CreatePowerUp(Vector2 position)
    {
        return Instantiate(powerUp, position, Quaternion.identity);
    }
}
