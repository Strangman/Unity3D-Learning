using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerScript : MonoBehaviour
{
    [SerializeField] private HingeJoint _hingeJoint;
    [SerializeField] private Timer _timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        _hingeJoint.useMotor = true;
        _timer.gameObject.SetActive(true);
    }
}
