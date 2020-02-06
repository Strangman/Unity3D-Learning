using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadNewSceneScript : MonoBehaviour
{
    [SerializeField] private string _loadScene;
    [SerializeField] private string _loadKey;
    private void Awake()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(LoadNewScene);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadNewScene()
    {
        var getCoins = PlayerPrefs.GetInt(_loadKey);
        PlayerPrefs.SetInt(_loadKey, getCoins + FindObjectOfType<CoinControllerScript>().GetCoins());
        SceneManager.LoadScene(_loadScene);
    }
}
