using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using static UnityEngine.Rendering.DebugUI;

public class PlayerModifaer : MonoBehaviour
{
    [SerializeField] int _high;
    [SerializeField] int _wight;
    float _wightPlayer = 0.005f;
    float _highPlayer = 0.01f;
    [SerializeField] Renderer _renderer;
    [SerializeField] Transform _topspine;
    [SerializeField] Transform _bottomspine;
    [SerializeField] Transform _colliderTransform;   
    public void AddWight(int value)
    {
        _wight += value;
        UpdateWight();
    }
    public void AddHigh(int value)
    {
        _high += value;
    }   
    public void RemoveHigh()
    {
        float offsetY = _high * _highPlayer + 0.17f;
        _topspine.position = _bottomspine.position + new Vector3(0, offsetY, 0);
        _colliderTransform.localScale = new Vector3(1, 1.84f + _high * _highPlayer, 1);
    }
    private void Start()
    {
        SetWight(Progres.Instance.Wight);
        SetHigh(Progres.Instance.High);
    }
    public void SetWight(int value)
    {
        _wight = value;
        UpdateWight();
    }
    public void SetHigh(int value) 
    {       
        _high = value;
        RemoveHigh();
    }  
    public void HitBarier()
    {     
        if (_high > 0 && _wight > 0)
        {    
            _high -= 20;        
            RemoveHigh();
            _wight -= 20;
            UpdateWight();
        }        
        else 
        {
            Die();
        } 
    }
    public void UpdateWight()
    {
        _renderer.material.SetFloat("_PushValue", _wight * _wightPlayer);
    }
    void Die() 
    {
        FindAnyObjectByType<GameManager>().ShowFinishShow();
        Destroy(gameObject);     
    }
}