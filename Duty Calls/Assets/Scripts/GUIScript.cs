using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour
{
    [SerializeField] private Text _hpText;

    private PlayerHPScript _playerHPScript;

    private void Awake()
    {
        _playerHPScript = GetComponent<PlayerHPScript>();
        SetHPText(_playerHPScript.GetHP());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            var trap = collision.gameObject.GetComponent<TrapScript>();
            var damage = trap.GetDamage();
            _playerHPScript.Decreace(damage);
            SetHPText(_playerHPScript.GetHP());
        }
    }

    private void SetHPText(int hp)
    {
        _hpText.text = $"HP {hp}";
    }
}
