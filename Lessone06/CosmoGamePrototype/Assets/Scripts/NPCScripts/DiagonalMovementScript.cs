using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalMovementScript : MonoBehaviour
{
    [SerializeField] private float _verticalSpeed;
    [SerializeField] private float _horizontalSpeed;
    [SerializeField] private float _horizontalBorder;

    private void Awake()
    {
        int random = Random.Range(0,2);

        if(random == 0)
        {
            _horizontalSpeed *= -1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= _horizontalBorder)
        {
            _horizontalSpeed *= -1;
        }
        else if(transform.position.x <= -(_horizontalBorder))
        {
            _horizontalSpeed *= -1;
        }

        Vector3 vector3 = new Vector3(_horizontalSpeed, -(_verticalSpeed));
        transform.position += vector3;
    }
}
