using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum LoadKey
{
    Coin,
    Health,
    HealthLevel,
    Damage,
    DamageLevel,
    FirstEnter,
    OpenedLevel,
    Music,
    Sound
}
public class StoreCoinShowScript : MonoBehaviour
{
    [SerializeField] private LoadKey _loadKey;
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
        var getCoins = PlayerPrefs.GetInt(_loadKey.ToString());
        getCoins += coin;
        PlayerPrefs.SetInt(_loadKey.ToString(), getCoins);
        gameObject.GetComponent<Text>().text = getCoins.ToString();
    }

    public void DecreaseAmountOfCoin(int coin)
    {
        var getCoins = PlayerPrefs.GetInt(_loadKey.ToString());
        getCoins -= coin;
        PlayerPrefs.SetInt(_loadKey.ToString(), getCoins);
        gameObject.GetComponent<Text>().text = getCoins.ToString();
    }
}
