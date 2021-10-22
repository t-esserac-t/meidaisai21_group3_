using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public float time;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        time = 10;

        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeText.text = "TIME: "+ time;

        if (time <= 0)
        {
            SceneManager.LoadScene("Result");

        }
    }
}
