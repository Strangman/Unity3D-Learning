using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetectionScript : MonoBehaviour
{
    [SerializeField] private NPCBodyScript _body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<BulletScript>(out BulletScript bullet))
        {
            _body.HitDetection(bullet.GetBulletDamage());
            Destroy(collision.gameObject);
        }
    }
}
