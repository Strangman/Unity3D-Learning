using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndgameScore : MonoBehaviour
{
    //Get Text component.
    private Text _text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //methode that sets Text component of the object.
    public void SetEndScore(int endscore)
    {
        _text = gameObject.GetComponent<Text>();
        _text.text = endscore.ToString();
    }
}
