using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemy;
    [SerializeField] private int _enemyGroupSize;
    [SerializeField] private float _timeForSpawn;
    [SerializeField] private Vector3[] _spawnPoint;
    [SerializeField] private Vector3 _distansBetweenEnemy;
    private float _timeCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timeCounter += Time.deltaTime;
        if(_timeCounter >= _timeForSpawn)
        {
            SpawnEnemy();
            _timeCounter = 0;
        }
    }

    public void SpawnEnemy()
    {
        int randomSpawnPoint = Random.Range(0, _spawnPoint.Length);
        for(int i =0; i <_enemyGroupSize; i++)
        {
            Instantiate(_enemy[Random.Range(0, _enemy.Length)], _spawnPoint[randomSpawnPoint] + (_distansBetweenEnemy * i), Quaternion.Euler(180, 0, 0));
        }
    }
}
