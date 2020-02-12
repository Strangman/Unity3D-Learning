using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOnScript : MonoBehaviour
{

    private const LoadKey _musicLoadKey = LoadKey.Music;

    private void Awake()
    {
        bool soundState = PlayerPrefs.GetInt(_musicLoadKey.ToString()) == 0 ? true : false;
        gameObject.GetComponent<AudioSource>().mute = !soundState;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
