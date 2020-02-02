using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScript : MonoBehaviour
{
    //How boost will change player firerate.
    [SerializeField] private float _boostPower;
    //Speed of boost fall.
    [SerializeField] private float _boostMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Boost movement.
        gameObject.transform.position += Vector3.down * _boostMove;
    }
    //Boost action wahen colide with player.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            collision.GetComponent<PlayerScript>().TakeBoost(_boostPower);
        }
        //move.TakeBoost(_boostPower);
    }
}
