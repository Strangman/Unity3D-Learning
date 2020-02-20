using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteract : MonoBehaviour, IOpenCloseInteract
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActionOnInteract(bool isOpen)
    {
        if (isOpen)
        {
            _animator.SetBool("isOpen", true);
        }
        else
        {
            _animator.SetBool("isOpen", false);
        }
        
    }
}
