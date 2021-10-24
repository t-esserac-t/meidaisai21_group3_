using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public float result;
    public Text resultText;

    // Start is called before the first frame update
    void Start()
    {
        result = PlayerPrefs.GetInt("score", 0);
        resultText.text = "Number of hits: " + result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
