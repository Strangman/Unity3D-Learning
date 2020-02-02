using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenFirstLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
