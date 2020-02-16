using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Explosion()
    {
        RaycastHit hit;
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius);
        foreach (var item in colliders)
        {
            var rbCollider = item.GetComponent<Rigidbody>();
            if (rbCollider != null)
            {
                rbCollider.AddExplosionForce(_force, transform.position, _radius);
            }
        }
    }
}
