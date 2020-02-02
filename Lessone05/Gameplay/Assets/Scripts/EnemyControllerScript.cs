using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerScript : MonoBehaviour
{
    //Set enemy group or one enemy that need to activate.
    [SerializeField] private GameObject[] _enemyControlGroups = null;
    //time between activations.
    [SerializeField] private float _time;
    //Which group will select in current circl.
    private int _groupNumber;
    //Counter for time.
    private float _timeCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timeCounter += Time.deltaTime;
        if(_timeCounter >= _time && _groupNumber < _enemyControlGroups.Length)
        {
            ActivateEnemyGroup(_groupNumber);
            _groupNumber++;
            _timeCounter = 0f;
        }
    }
    //Methode for activations of enemy group.
    public void ActivateEnemyGroup(int number)
    {
        _enemyControlGroups[number].gameObject.SetActive(true);
    }
}
