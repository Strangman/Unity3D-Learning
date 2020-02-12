using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicAndSoundStateSaveScript : MonoBehaviour
{
    [SerializeField] private LoadKey _loadKey;
    private void Awake()
    {
        int loadState = PlayerPrefs.GetInt(_loadKey.ToString());
        bool togleState = loadState == 0 ? true : false; 
        gameObject.GetComponent<Toggle>().isOn = togleState;
        gameObject.GetComponent<Toggle>().onValueChanged.AddListener(TogleChager);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TogleChager(bool state)
    {
        int saveState = state ? 0 : 1;
        PlayerPrefs.SetInt(_loadKey.ToString(), saveState);
    }
}
