using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBihavior : MonoBehaviour
{
    //Speed of npc.
    [SerializeField] private float _NPCSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //NPC movement.
        transform.position += Vector3.down * _NPCSpeed;
    }
}
