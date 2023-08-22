using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coinsmanager : MonoBehaviour
{
     public  int _moneyCount;
    [SerializeField] TextMeshProUGUI _text;
    private void Start()
    {
        _moneyCount = Progres.Instance.Coins;
        _text.text = _moneyCount.ToString();
    }
    public void AddOne()
    {
        _moneyCount++;
      
        _text.text = _moneyCount.ToString();
    }

    public void SaveToProgress()
    {
        Progres.Instance.Coins = _moneyCount;

    }

    public void SpendMoney(int value)
    {
        _moneyCount -= value;
        _text.text = _moneyCount.ToString();
    }
}