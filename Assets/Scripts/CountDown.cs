using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public float time;
    private float time2;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        time = 20;

        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        time2 = Mathf.Floor(time * 10) / 10;
        timeText.text = "TIME: "+ time2;

        if (time <= 0)
        {
            SceneManager.LoadScene("Result");

        }
    }
}
