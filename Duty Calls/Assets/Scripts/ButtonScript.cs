using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private InteractScript _interactableGameObject;
    private Animation _animation;
    private bool _isActivated;

    private void Awake()
    {
        _animation = GetComponent<Animation>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InteractButton()
    {
        if (_isActivated)
        {
            _animation.Play("ButtonOut");
            _isActivated = false;
            _interactableGameObject.Interact(_isActivated);
        }
        else
        {
            _animation.Play("Button");
            _isActivated = true;
            _interactableGameObject.Interact(_isActivated);
        }
    }
}
