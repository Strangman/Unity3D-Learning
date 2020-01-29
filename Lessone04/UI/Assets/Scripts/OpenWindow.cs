using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenWindow : MonoBehaviour
{
    [SerializeField] private Button _openButton1;
    [SerializeField] private GameObject _openedWindow1;
    [SerializeField] private Button _openButton2;
    [SerializeField] private GameObject _openedWindow2;
    [SerializeField] private Button _openButton3;
    [SerializeField] private GameObject _openedWindow3;
    [SerializeField] private Button _openButton4;
    [SerializeField] private GameObject _openedWindow4;
    [SerializeField] private Button _closeWindowButton;

    private void Awake()
    {
       _openButton1.onClick.AddListener(OpenOpenedWindow1);
       _openButton2.onClick.AddListener(OpenOpenedWindow2);
       _openButton3.onClick.AddListener(OpenOpenedWindow3);
       _openButton4.onClick.AddListener(OpenOpenedWindow4);
       _closeWindowButton.onClick.AddListener(CloseWindow);
    }

    private void OpenOpenedWindow1()
    {
        _openedWindow1.SetActive(true);
        gameObject.SetActive(false);
    }
    private void OpenOpenedWindow2()
    {
        _openedWindow2.SetActive(true);
        gameObject.SetActive(false);
    }
    private void OpenOpenedWindow3()
    {
        _openedWindow3.SetActive(true);
        gameObject.SetActive(false);
    }
    private void OpenOpenedWindow4()
    {
        _openedWindow4.SetActive(true);
        gameObject.SetActive(false);
    }
    private void CloseWindow()
    {
        Application.Quit();
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
