using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBehavior : MonoBehaviour
{
    [SerializeField] Move _move;
    [SerializeField] Cameramove _cameramove;
    [SerializeField] Animator _animator;
    [SerializeField] Particle _particle;
    [SerializeField] AudioSource _playSoundLevel1;
    void Start()
    {
        
        _move.enabled= false;
        _cameramove.enabled= false;
        _particle.enabled= false;
    }
    public void Play()
    {
        _playSoundLevel1.Play();
        _animator.SetTrigger("run");
        _move.enabled= true;
         _cameramove.enabled= true;
        _particle.enabled= true;
    }
  
    public void StatrFinishBehavior()
    {
        _playSoundLevel1.Stop();
        _move.enabled = false;
        _cameramove.enabled = false;
        _particle.enabled= false;
        _animator.SetTrigger("dance");

    }
}
