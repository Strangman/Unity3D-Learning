using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenWindow : MonoBehaviour
{
    [SerializeField] private OpeningWindow[] _openingWindows = null;

    private void Awake()
    {
       foreach(var item in _openingWindows)
        {
            item._openButton.onClick.AddListener(() => OnWindowOpen(item));
        }
    }

    private void OnWindowOpen(OpeningWindow openingWindow)
    {
        var isActive = openingWindow._openedWindow.activeSelf;
        openingWindow._openedWindow.SetActive(!isActive);
        gameObject.SetActive(false);
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

[Serializable]
public class OpeningWindow
{
    public Button _openButton;
    public GameObject _openedWindow;
}
