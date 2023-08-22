using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{

    // Update is called once per frame
    void LateUpdate()
    {

        if (FindAnyObjectByType<Move>())
            transform.position = transform.position + new Vector3(0, 0, FindAnyObjectByType<Move>().speedPlayer * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.A) && gameObject.transform.position.x >= 0)
                {
                         transform.position += new Vector3(-1, 0, 0);
                }
            if (Input.GetKeyDown(KeyCode.D) && gameObject.transform.position.x <= 0)
                {
                         transform.position += new Vector3(1, 0, 0);
                }
        else
        {
             transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }

    }
}
