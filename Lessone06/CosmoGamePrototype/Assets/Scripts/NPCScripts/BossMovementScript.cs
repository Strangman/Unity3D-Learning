using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovementScript : MonoBehaviour
{
    [SerializeField] private float _verticalSpeed;
    [SerializeField] private float _horizontalSpeed;
    [SerializeField] private float _verticalBorder;
    [SerializeField] private float _horizontalBorder;
    [SerializeField] private float _atackTime;
    private bool _isBack;
    private bool _onAttack;
    private float _timeCounter;
    private float _timeAfterAttack;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        _timeCounter += Time.deltaTime;

        if(!_onAttack)
        {
            if (transform.position.x >= _horizontalBorder)
            {
                _horizontalSpeed *= -1;
            }
            else if (transform.position.x <= -(_horizontalBorder))
            {
                _horizontalSpeed *= -1;
            }

            transform.position += Vector3.left * _horizontalSpeed;
        }

        if (_timeCounter >= _atackTime & !_isBack)
        {
            _onAttack = true;
            transform.position += Vector3.down * _verticalSpeed;
            if(transform.position.y <= -(_verticalBorder))
            {
                _isBack = true;
                _timeAfterAttack = _timeCounter + 1;
            }
        }
        else if(_isBack & _timeCounter >= _timeAfterAttack)
        {
            transform.position += Vector3.up * _verticalSpeed;
            if (transform.position.y >= _verticalBorder)
            {
                _timeCounter = 0;
                _isBack = false;
                _onAttack = false;
            }
        }
    }
}
