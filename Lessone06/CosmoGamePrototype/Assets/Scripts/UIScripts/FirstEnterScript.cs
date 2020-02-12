using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEnterScript : MonoBehaviour
{
    [SerializeField] private int _firstEnter;
    private LoadKey _coinLoad = LoadKey.Coin;
    private LoadKey _healthLoad = LoadKey.Health;
    private LoadKey _damageLoad = LoadKey.Damage;
    private LoadKey _firstEnterLoad = LoadKey.FirstEnter;
    private LoadKey _healthLevelLoad = LoadKey.HealthLevel;
    private LoadKey _damageLevelLoad = LoadKey.DamageLevel;
    private LoadKey _openedLevelLoad = LoadKey.OpenedLevel;
    private void Awake()
    {
        _firstEnter = PlayerPrefs.GetInt(_firstEnterLoad.ToString());
        if(_firstEnter == 0)
        {
            ReserToDefault();
            _firstEnter = 1;
            PlayerPrefs.SetInt(_firstEnterLoad.ToString(), _firstEnter);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            ReserToDefault();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.SetInt(_firstEnterLoad.ToString(), 0);
        }
    }

    private void ReserToDefault()
    {
        PlayerPrefs.SetInt(_coinLoad.ToString(), 0);
        PlayerPrefs.SetInt(_healthLoad.ToString(), 10);
        PlayerPrefs.SetInt(_damageLoad.ToString(), 10);
        PlayerPrefs.SetInt(_healthLevelLoad.ToString(), 1);
        PlayerPrefs.SetInt(_damageLevelLoad.ToString(), 1);
        PlayerPrefs.SetInt(_openedLevelLoad.ToString(), 0);
    }
}
