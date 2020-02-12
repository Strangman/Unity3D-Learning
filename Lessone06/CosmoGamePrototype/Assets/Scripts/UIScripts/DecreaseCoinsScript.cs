using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecreaseCoinsScript : MonoBehaviour
{
    [SerializeField] private StoreCoinShowScript _storeCoin;
    [SerializeField] private int _howmanyCoins;
    [SerializeField] private LoadKey _loadKeyUpgrade;
    [SerializeField] private LoadKey _loadKeyUpgradeLevel;
    [SerializeField] private int _levelCup;
    [SerializeField] private int _upgradeSize;
    [SerializeField] private UpgradeLevelTextScript _upgradeLevelTextScript;
    [SerializeField] private BuyButtonTextScript _buyButton;
    private const LoadKey _coinLoadKey = LoadKey.Coin;
    private void Awake()
    {
        _buyButton.ChangeButtonText(_howmanyCoins);
        gameObject.GetComponent<Button>().onClick.AddListener(DecreaceCoins);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DecreaceCoins()
    {
        int playerCoins = PlayerPrefs.GetInt(_coinLoadKey.ToString());
        int currentUpgradeLevel = PlayerPrefs.GetInt(_loadKeyUpgradeLevel.ToString());
        int currentCost = _howmanyCoins * currentUpgradeLevel;

        if (playerCoins >= currentCost && currentUpgradeLevel < _levelCup)
        {
            _storeCoin.DecreaseAmountOfCoin(currentCost);
            var playerLevel = PlayerPrefs.GetInt(_loadKeyUpgrade.ToString());
            playerLevel += _upgradeSize;
            PlayerPrefs.SetInt(_loadKeyUpgrade.ToString(), playerLevel);
            currentUpgradeLevel++;
            PlayerPrefs.SetInt(_loadKeyUpgradeLevel.ToString(), currentUpgradeLevel);
            _upgradeLevelTextScript.ChangeText();
            _buyButton.ChangeButtonText(_howmanyCoins);
        }
    }
}
