using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBodyScript : MonoBehaviour
{
    [SerializeField] private int _hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            _hp -= 1;
            if(_hp <= 0)
            {
                Destroy(gameObject);
                var endgame = FindObjectOfType<EndGameController>();
                endgame.ReversePlayerState();
                endgame.EndGameEvent();
            }
        }
    }
}
