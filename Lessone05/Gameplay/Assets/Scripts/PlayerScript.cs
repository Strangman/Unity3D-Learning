using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //player speed.
    [SerializeField] private float _speed;
    //For bullet pref that player will generate.
    [SerializeField] private GameObject _bulet;
    //How fast will bullets generate.
    [SerializeField] private float _fireRate;
    //how many coins player have.
    [SerializeField] private int _currentCoin;
    //How many HP player have.
    [SerializeField] private int _hp;
    //gameobject of endgame Window for taking coins.
    [SerializeField] private GameObject _endIcon;
    //time counter for firerate.
    private float _fireRateCounter;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //For up and down movement.
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * _speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * _speed;
        }

        //For left end right movement.
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * _speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * _speed;
        }

        //When bullet will be created.
        _fireRateCounter += Time.deltaTime;

        if (_fireRate <= _fireRateCounter)
        {
            Fire();
            _fireRateCounter = 0;
        }

        //What will happend when HP drops to 0.
        if (_hp <= 0)
        {
            Death();
        }
    }

    //methode for creating bullet.
    private void Fire()
    {
        Vector3 playerPosition = gameObject.transform.position;
        Instantiate(_bulet, playerPosition, Quaternion.identity);
    }

    //Methode that increase firerate.
    public void TakeBoost(float boost)
    {
        _fireRate -= boost;
        if(_fireRate < 0.1)
        {
            _fireRate = 0.1f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When take coin.
        if(collision.tag == "Coin")
        {
            _currentCoin += collision.GetComponent<CoinScript>().GetCoinCost();
            Destroy(collision.gameObject);
        }
        //When hit enemy.
        if(collision.tag == "Enemy")
        {
            _hp -= 2;
        }
    }
    //methode for getting coins in endgame.
    public int GetCoins()
    {
        return _currentCoin;
    }
    //What will heppend whe you die.
    private void Death()
    {
        Destroy(gameObject);
        _endIcon.SetActive(true);
    }
}
