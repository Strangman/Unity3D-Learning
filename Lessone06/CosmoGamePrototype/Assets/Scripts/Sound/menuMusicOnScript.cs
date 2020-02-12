using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuMusicOnScript : MonoBehaviour
{
    [SerializeField] private AudioSource _menuMusicSource;
    private void Awake()
    {
        gameObject.GetComponent<Toggle>().onValueChanged.AddListener(OnOfMenuMusic);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnOfMenuMusic(bool state)
    {
        _menuMusicSource.mute = !state;
    }
}
