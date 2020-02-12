using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChosedLevelScript : MonoBehaviour
{
    [SerializeField] private string _loadedLevelName;
    [SerializeField] private int _levelCount;
    [SerializeField] private ChoseLevelController _choseLevelController;
    private const LoadKey _openedLevelKey = LoadKey.OpenedLevel;
    private void Awake()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(SetLevel);
        var openedLevel = PlayerPrefs.GetInt(_openedLevelKey.ToString());
        if(openedLevel >= _levelCount)
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetLevel()
    {
        _choseLevelController.SelectLevel(_loadedLevelName, _levelCount);
    }
}
