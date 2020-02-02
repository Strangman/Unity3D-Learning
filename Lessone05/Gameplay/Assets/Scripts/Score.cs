using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //For score text.
    private Text _score;
    //Wher current score is stored.
    private int _currentScore;
    private void Awake()
    {
        //Set score by 0.
        _score = gameObject.GetComponent<Text>();
        _score.text = _currentScore.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Methode for increasing score.
    public void AddScore(int takeScore)
    {
        _currentScore += takeScore;
        _score = gameObject.GetComponent<Text>();
        _score.text = _currentScore.ToString();
    }
    //Methode for getting score in endgame.
    public int GetScore()
    {
        return _currentScore;
    }
}
