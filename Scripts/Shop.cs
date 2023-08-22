using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    [SerializeField] Coinsmanager _coinsmanager;
    PlayerModifaer _playerModifaer;

    private void Start()
    {
        _playerModifaer = FindAnyObjectByType<PlayerModifaer>();    
    }
    public void BuyWight()
    {
        if (_coinsmanager._moneyCount >= 30)
        {
            _coinsmanager.SpendMoney(30);
            Progres.Instance.Coins = _coinsmanager._moneyCount;
            Progres.Instance.Wight += 25;
            _playerModifaer.SetWight(Progres.Instance.Wight);
        }
    }
    public void BuyHigh()
    {
        if (_coinsmanager._moneyCount >= 30)
        {
            _coinsmanager.SpendMoney(30);
            Progres.Instance.Coins = _coinsmanager._moneyCount;
            Progres.Instance.High += 25;
            _playerModifaer.SetHigh(Progres.Instance.High);
        }
    }
}
