using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour
{
    [SerializeField] Text hstext;

    // Start is called before the first frame update
    void Start()
    {
        hstext.text = "Test String works";
        Debug.Log("String should be up");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
