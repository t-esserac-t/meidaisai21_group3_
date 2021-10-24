using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ClearOrFailed : MonoBehaviour
{
    public Result resultScore;

    //public float clearOrFailure;
    public Text clearOrFailureText; 

    // Start is called before the first frame update
    void Start()
    {
        float clearOrFailure = resultScore.result;
        if(clearOrFailure>=10)
        {
            clearOrFailureText.text = "CLEAR";
        }
        else
        {
            clearOrFailureText.text = "FAILURE";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
