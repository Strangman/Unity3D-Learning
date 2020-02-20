using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    [SerializeField] private IOpenCloseInteract _interact;

    private void Awake()
    {
        _interact = GetComponent<IOpenCloseInteract>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact(bool isOpened)
    {
        _interact.ActionOnInteract(isOpened);
    }
}

