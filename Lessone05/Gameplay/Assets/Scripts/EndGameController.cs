using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    //When game will end.
    [SerializeField] private float _endgame;
    //For endgame icon activation.
    [SerializeField] private GameObject _endIcon;
    //script than have current score.
    [SerializeField] private Score _score;
    //For score text icon in endgame window.
    [SerializeField] private EndgameScore _endgameScore;
    //script htat have current colected coins.
    [SerializeField] private PlayerScript _player;
    //For coin text icon in endgame window.
    [SerializeField] private EndgameScore _endgameCoins;
    //For coins in store.
    [SerializeField] private CurentCoins _curentCoins;
    //Counter before endgame script will activate.
    private float _endgameCounter;
    private int _endgameStop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _endgameCounter += Time.deltaTime;
        //What will happen in the end of counter.
        if(_endgameCounter >= _endgame && _endgameStop == 0)
        {
            EndgameScript();
            _endgameStop++;
        }
    }
    //Activate endgame window and sets score and coins.
    public void EndgameScript()
    {
        _endgameScore.SetEndScore(_score.GetScore());
        _endgameCoins.SetEndScore(_player.GetCoins());
        _curentCoins.AddCoins(_player.GetCoins());
        _endIcon.SetActive(true);
    }
}
