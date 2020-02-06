using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControllerScript : MonoBehaviour
{
    [SerializeField] private int _currentscore;
    [SerializeField] private ShowScoreScript _showScoreScript;

    private void Awake()
    {
        AddScore(0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int score)
    {
        _currentscore += score;
        _showScoreScript.ShowScore(_currentscore);
    }
    public int GetScore()
    {
        return _currentscore;
    }
}
