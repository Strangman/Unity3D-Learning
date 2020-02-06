using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBodyScript : MonoBehaviour
{
    [SerializeField] private int _hp;
    [SerializeField] private int _deathScore;
    [SerializeField] private float _destroyMark;
    [SerializeField] private CreateOnDestroyScript _createOnDestroyScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < _destroyMark)
        {
            OvertheDestroyMark();
        }
    }

    public void HitDetection(int hit)
    {
        _hp -= hit;
        if(_hp <= 0)
        {
            Destroy(gameObject);
            _createOnDestroyScript?.CreateOnDestroy();
            FindObjectOfType<ScoreControllerScript>().AddScore(_deathScore);
        }
    }
    public void OvertheDestroyMark()
    {
        Destroy(gameObject);
    }
}
