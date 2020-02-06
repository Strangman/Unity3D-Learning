using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreCoinShowScript : MonoBehaviour
{
    [SerializeField] private string _loadKey;
    private void Awake()
    {
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("Coin").ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddAmountOfCoin(int coin)
    {
        var getCoins = PlayerPrefs.GetInt(_loadKey);
        getCoins += coin;
        PlayerPrefs.SetInt(_loadKey, getCoins);
        gameObject.GetComponent<Text>().text = getCoins.ToString();
    }
}
