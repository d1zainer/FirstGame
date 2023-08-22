using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barier : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject _brickEffectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifaer playerModifaer = other.attachedRigidbody.GetComponent<PlayerModifaer>();
        if (playerModifaer) 
        { 
            playerModifaer.HitBarier();
            Destroy(gameObject);
            Instantiate(_brickEffectPrefab,transform.position, transform.rotation);
        }
    }
}
