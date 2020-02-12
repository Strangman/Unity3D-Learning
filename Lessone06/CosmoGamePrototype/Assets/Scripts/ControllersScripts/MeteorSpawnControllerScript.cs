using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawnControllerScript : MonoBehaviour
{
    [SerializeField] private GameObject _meteor;
    [SerializeField] private float _timeForSpawn;
    [SerializeField] private Vector3[] _spawnPoint;
    private float _timeCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timeCounter += Time.deltaTime;
        if (_timeCounter >= _timeForSpawn)
        {
            SpawnMeteor();
            _timeCounter = 0;
        }
    }
    private void SpawnMeteor()
    {
        int randomSpawnPoint = Random.Range(0, _spawnPoint.Length);
        Instantiate(_meteor, _spawnPoint[randomSpawnPoint], Quaternion.Euler(180, 0, 0));
    }
}
