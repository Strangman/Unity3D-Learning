using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStatus : MonoBehaviour
{
    [SerializeField] private bool _isActiveOnStart;

    private void Awake()
    {
        gameObject.SetActive(_isActiveOnStart);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
