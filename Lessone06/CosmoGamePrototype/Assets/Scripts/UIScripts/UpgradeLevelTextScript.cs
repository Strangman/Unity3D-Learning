using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeLevelTextScript : MonoBehaviour
{
    [SerializeField] private LoadKey _loadKey;
    [SerializeField] private string _innerText;

    private void Awake()
    {
        ChangeText();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText()
    {
        gameObject.GetComponent<Text>().text = $"{_innerText}: {PlayerPrefs.GetInt(_loadKey.ToString())}";
    }
}
