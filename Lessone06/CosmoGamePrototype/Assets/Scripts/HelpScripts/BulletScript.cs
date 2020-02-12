using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    [SerializeField] private float _verticalBorder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
        if(transform.position.y > _verticalBorder)
        {
            Destroy(gameObject);
        }
    }
    private void BulletMove()
    {
        transform.position += Vector3.up * _speed;
    }
    public int GetBulletDamage()
    {
        return _damage;
    }
    public void BulletShot(int damage, Vector3 gunPosition)
    {
        _damage = damage;
        Instantiate(gameObject, gunPosition, Quaternion.identity);
    }
}
