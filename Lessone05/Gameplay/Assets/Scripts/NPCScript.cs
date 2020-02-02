using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    //How many HP have enemy.
    [SerializeField] private int _hp;
    //How mane score will you have after death.
    [SerializeField] private int _deathScore;
    //Set for score gameoject.
    [SerializeField] private Score score;
    //What will drop if NPC die.
    [SerializeField] private GameObject _deathCreate1;
    //What will drop if NPC die.
    [SerializeField] private GameObject _deathCreate2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //What heppend when NPC die.
        if(_hp<= 0)
        {
            Destroy(gameObject);
            score.AddScore(_deathScore);
            Vector3 enemyPosition = gameObject.transform.position;
            //Randow for NPC drop.
            switch (Random.Range(0, 2))
            {
                case 0:
                    Instantiate(_deathCreate1, enemyPosition, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(_deathCreate2, enemyPosition, Quaternion.identity);
                    break;
            }
        }
    }
    //What will heppend when enemy reach the bullet.
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Bullet")
        {
            var bullet = collider.GetComponent<BulletMove>();
            _hp -= bullet.GetDamage(); ;
            Destroy(collider.gameObject);
        }
    }
}
