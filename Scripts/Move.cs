using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private int moneyCount;
    [SerializeField] public float speedPlayer;
    [SerializeField] Animator _Animator;

    // Update is called once per frame
    void Update()
    {
       
        _Animator.transform.position = transform.position + new Vector3(0, 0, speedPlayer * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.A) && gameObject.transform.position.x >= 0) 
            {
                transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D) && gameObject.transform.position.x <= 0)
        {
            transform.position += new Vector3(1, 0, 0);          
        }
    }
}
