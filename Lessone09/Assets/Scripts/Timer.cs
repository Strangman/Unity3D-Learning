using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _timer;
    [SerializeField] private Bomb _bomb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_timer > 0)
        {
            _timer -= Time.deltaTime;
            gameObject.GetComponent<Text>().text = _timer.ToString();
        }
        else
        {
            _timer = 0;
            _bomb.Explosion();
        }
    }
}
