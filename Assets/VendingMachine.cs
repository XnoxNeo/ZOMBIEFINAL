using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingMachine : MonoBehaviour
{
    [SerializeField] private AbstractFactoryPowerUp powerUpFactory;
    [SerializeField] private Transform spawnPoint;

    public void VendingMachineActivation()
    {
        powerUpFactory.CreatePowerUp(spawnPoint.position);
    }

}
