using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowManyCoins : MonoBehaviour
{
    [SerializeField] private Button _buyButton;
    [SerializeField] private CurentCoins _curentCoins;
    [SerializeField] private int _haveCoins;
    private void Awake()
    {
        _buyButton.onClick.AddListener(AddCoins);
    }
    private void AddCoins()
    {
        _curentCoins.AddCoins(_haveCoins);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
