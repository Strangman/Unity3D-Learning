using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectObject : MonoBehaviour
{
    [SerializeField] private float _interactDistance;
    [SerializeField] private string _compareTag = "Selectable";
    [SerializeField] private Material _selectMaterial;

    private Transform _selected;
    private Material _selectedDefaultMaterial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_selected != null)
        {
            var selectRender = _selected.GetComponent<Renderer>();
            selectRender.material = _selectedDefaultMaterial;
            _selected = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, _interactDistance))
        {
            var selected = hit.transform;
            if (selected.CompareTag(_compareTag))
            {
                var selectedRenderer = selected.GetComponent<Renderer>();
                _selectedDefaultMaterial = selectedRenderer.material;
                selectedRenderer.material = _selectMaterial;
                _selected = selected;

                if(Input.GetKeyDown(KeyCode.E))
                {
                    Interact(selected);
                }
            }
            
        }
    }
    private void Interact(Transform selected)
    {
        if(selected.TryGetComponent<ButtonScript>(out ButtonScript buttonScript))
        {
            buttonScript.InteractButton();
        }
    }
}
