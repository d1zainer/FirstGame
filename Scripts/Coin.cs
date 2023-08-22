using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 270 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        FindAnyObjectByType<Coinsmanager>().AddOne();
        Destroy(gameObject);      
    }
}
