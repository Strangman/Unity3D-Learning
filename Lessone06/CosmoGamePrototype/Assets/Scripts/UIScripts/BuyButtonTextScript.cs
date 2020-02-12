using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButtonTextScript : MonoBehaviour
{
    [SerializeField] private LoadKey _loadKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeButtonText(int cost)
    {
        var currentCost = cost * PlayerPrefs.GetInt(_loadKey.ToString());
        gameObject.GetComponent<Text>().text = $"Upgrade \nCost {currentCost}";
    }
}
