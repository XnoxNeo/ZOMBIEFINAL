using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIVendingMachine : MonoBehaviour
{
    
    [SerializeField] private GameObject cash;
    private bool isInstantiated;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (GameManager.Instance.score >= 100)
        {
            isInstantiated = true;
            cash.SetActive(true);
        }
        if (GameManager.Instance.score < 100) 
        { 
            cash.SetActive(false);
        }
    }
}
