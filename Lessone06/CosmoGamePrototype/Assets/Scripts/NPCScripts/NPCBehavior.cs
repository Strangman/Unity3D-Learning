﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    [SerializeField] private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.position += Vector3.down * _speed;
    }
}
