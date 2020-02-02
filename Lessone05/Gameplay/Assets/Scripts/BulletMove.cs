using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    //Speed of bullet.
    [SerializeField] private float _bulletSpeed;
    //How many HP will bullet drop.
    [SerializeField] private int damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bullet movement.
        transform.position += Vector3.up * _bulletSpeed;
        //How long will bullet live.
        Destroy(gameObject, 0.9f);
    }
    //Bullet damage given methode.
    public int GetDamage()
    {
        return damage;
    }
}
