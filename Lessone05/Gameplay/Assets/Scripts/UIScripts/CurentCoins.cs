using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurentCoins : MonoBehaviour
{
    private Text _textCoins;
    public int currentCoins;
    private void Awake()
    {
        _textCoins = gameObject.GetComponent<Text>();
        _textCoins.text = currentCoins.ToString();
    }
    public void AddCoins(int coins)
    {
        currentCoins += coins;
        _textCoins = gameObject.GetComponent<Text>();
        _textCoins.text = currentCoins.ToString();
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
