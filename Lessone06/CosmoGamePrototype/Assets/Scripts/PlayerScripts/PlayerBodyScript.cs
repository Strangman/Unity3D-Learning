using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBodyScript : MonoBehaviour
{
    [SerializeField] private int _hp;
    [SerializeField] private HPShowScript _hpShow;
    private const LoadKey _loadKey = LoadKey.Health;

    private void Awake()
    {
        _hp = PlayerPrefs.GetInt(_loadKey.ToString());
        _hpShow.ChangeHPText(_hp);
    }
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
            _hp -= collision.GetComponent<NPCBodyScript>().GetDamageOnTouch();
            _hpShow.ChangeHPText(_hp);
            if (_hp <= 0)
            {
                _hpShow.ChangeHPText(0);
                Destroy(gameObject);
                var endgame = FindObjectOfType<EndGameController>();
                endgame.ReversePlayerState();
                endgame.EndGameEvent();
            }
        }
    }
}
