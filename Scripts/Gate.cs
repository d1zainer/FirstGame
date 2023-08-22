using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] DeformationType _deformationType;
    [SerializeField] GateApp _gateApp;

    private void OnValidate()
    {
        _gateApp.UpdateVision(_deformationType, value);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifaer playerModifaer = other.attachedRigidbody.GetComponent<PlayerModifaer>();
        if (playerModifaer)
        {
            if(_deformationType == DeformationType.wight)
            {
                playerModifaer.AddWight(value);
            }
            else if (_deformationType == DeformationType.high)
            {
                  
                playerModifaer.AddHigh(value);
                playerModifaer.RemoveHigh();                       
            }
            Destroy(gameObject);
        }
    }
    
}
