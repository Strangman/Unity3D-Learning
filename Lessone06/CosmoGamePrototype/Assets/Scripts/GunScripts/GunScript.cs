using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] private float _fireRate;
    [SerializeField] private float _maxFirerate;
    private float _fireRateCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _fireRateCounter += Time.deltaTime;
        if(_fireRateCounter >= _fireRate)
        {
            Shot();
            _fireRateCounter = 0;
        }
    }
    public void Shot()
    {
        var gunpoSition = transform.position;
        Instantiate(Resources.Load<GameObject>("Bullet/Bullet"), gunpoSition, Quaternion.identity);
    }
    public void ChageFiraRate(float boost)
    {
        if(_fireRate > _maxFirerate)
        {
            _fireRate -= boost;
        }
    }
}
