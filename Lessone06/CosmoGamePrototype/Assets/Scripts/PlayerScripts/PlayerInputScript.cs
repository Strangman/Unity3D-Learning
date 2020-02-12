using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _horizontalBorder;
    [SerializeField] private float _verticalBorder;
    [SerializeField] private GunScript _playerGun;
    [SerializeField] private GameObject[] _jetFlames;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < _verticalBorder)
        {
            MoveUp();
            ActivateFlames();
        }
        else if(Input.GetKey(KeyCode.S) && transform.position.y > (-_verticalBorder))
        {
            MoveDown();
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            foreach(var item in _jetFlames)
            {
                item.SetActive(false);
            }
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x > (-_horizontalBorder))
        {
            MoveLeft();
        }
        else if (Input.GetKey(KeyCode.D) && transform.position.x < _horizontalBorder)
        {
            MoveRight();
        }

        if(Input.GetKey(KeyCode.Space))
        {
            _playerGun.Shot();
        }
    }

    private void MoveUp()
    {
        transform.position += Vector3.up * _speed;
    }
    private void MoveDown()
    {
        transform.position += Vector3.down * _speed;
    }
    private void MoveLeft()
    {
        transform.position += Vector3.left * _speed;
    }
    private void MoveRight()
    {
        transform.position += Vector3.right * _speed;
    }
    private void ActivateFlames()
    {
        foreach(var item in _jetFlames)
        {
            item.SetActive(true);
        }
    }
}
