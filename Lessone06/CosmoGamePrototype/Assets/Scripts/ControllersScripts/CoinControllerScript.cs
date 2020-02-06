using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControllerScript : MonoBehaviour
{
    [SerializeField] private int _currentCoins;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoin(int coin)
    {
        _currentCoins += coin;
    }
    public int GetCoins()
    {
        return _currentCoins;
    }
}
