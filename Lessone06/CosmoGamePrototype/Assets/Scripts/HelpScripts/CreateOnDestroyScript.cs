using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOnDestroyScript : MonoBehaviour
{
    [SerializeField] private GameObject[] _createdObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateOnDestroy()
    {
        var bodyPosition = gameObject.transform.position;
        Instantiate(_createdObjects[Random.Range(0, _createdObjects.Length)], bodyPosition, Quaternion.identity);
    }
}
