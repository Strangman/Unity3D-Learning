using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoseLevelController : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Text _levelSelectedText;
    private string _levelName;

    private void Awake()
    {
        _playButton.onClick.AddListener(LoadLevel);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectLevel(string name, int levelCount)
    {
        _levelName = name;
        _levelSelectedText.text = $"Level {levelCount}";
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(_levelName);
    }
}
