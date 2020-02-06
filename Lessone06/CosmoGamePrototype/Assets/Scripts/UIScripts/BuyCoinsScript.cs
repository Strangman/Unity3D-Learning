using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCoinsScript : MonoBehaviour
{
    [SerializeField] private StoreCoinShowScript _storeCoin;
    [SerializeField] private int _howmanyCoins;

    private void Awake()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(BuyCoins);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void BuyCoins()
    {
        _storeCoin.AddAmountOfCoin(_howmanyCoins);
    }
}
