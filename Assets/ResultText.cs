using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultText : MonoBehaviour
{
    public Text resultText;

    // Start is called before the first frame update
    void Start()
    {
      int resultScore = PlayerPrefs.GetInt("score", 0);
        resultText.text = "Number of hits: " + resultScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
            GameObject.Find("GameMain").GetComponent<GameMain>().calcDamage();
     */
}
