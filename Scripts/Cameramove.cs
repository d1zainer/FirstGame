using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cameramove : MonoBehaviour
{


    // Update is called once per frame
    void LateUpdate()
    {
        if (FindAnyObjectByType<Move>())
            transform.position = transform.position + new Vector3(0, 0, FindAnyObjectByType<Move>().speedPlayer * Time.deltaTime);
        else
        {
            transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
