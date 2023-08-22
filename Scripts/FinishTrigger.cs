using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource playsound;
    private void OnTriggerEnter(Collider other)
    {
        PlayBehavior playBehavior = other.attachedRigidbody.GetComponent<PlayBehavior>();
        if (playBehavior)
        {

            playsound.Play();
            playBehavior.StatrFinishBehavior();
            FindAnyObjectByType<GameManager>().ShowFinishShow();
        }
    }
}
