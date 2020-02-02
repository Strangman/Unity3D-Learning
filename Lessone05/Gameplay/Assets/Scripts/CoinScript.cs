using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    //How many coins do you get when you pick up it.
    [SerializeField] private int _coinCost;
    //Speed of coin.
    [SerializeField] private float _coinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Coin movement.
        transform.position += Vector3.down * _coinSpeed;
    }
    //methode that gives cost of coin.
    public int GetCoinCost()
    {
        return _coinCost;
    }
}
