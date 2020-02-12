using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    [SerializeField] private GameObject _endWindow;
    [SerializeField] private ChageTextScript _loseOrWinText;
    [SerializeField] private ScoreControllerScript _scoreControllerScript;
    [SerializeField] private ShowScoreScript _showEndScore;
    [SerializeField] private CoinControllerScript _coinControllerScript;
    [SerializeField] private ShowScoreScript _showEndCoin;
    [SerializeField] private int _openedLevel;
    private const LoadKey _openedlevelKey = LoadKey.OpenedLevel;
    private bool _playerIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReversePlayerState()
    {
        _playerIsAlive ^= true;
    }
    public void EndGameEvent()
    {
        FindObjectOfType<EnemySpawnController>()?.gameObject.SetActive(false);
        if(_playerIsAlive)
        {
            _loseOrWinText.ChangeText("You win");
            PlayerPrefs.SetInt(_openedlevelKey.ToString(), _openedLevel);
        }
        else
        {
            _loseOrWinText.ChangeText("You lose");
        }
        _showEndScore.ShowScore(_scoreControllerScript.GetScore());
        _showEndCoin.ShowScore(_coinControllerScript.GetCoins());
        _endWindow.SetActive(true);
    }
}
