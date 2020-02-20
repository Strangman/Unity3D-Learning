using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    [SerializeField] private int _damage;

    private void Awake()
    {
        gameObject.tag = "Trap";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetDamage()
    {
        return _damage;
    }
}
