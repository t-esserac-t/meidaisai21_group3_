using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ClearOrFailed : MonoBehaviour
{
    public Result resultScore;
    public static float clearCount=130;
    //public float clearOrFailure;
    public Text clearOrFailureText; 

    // Start is called before the first frame update
    void Start()
    {
        float clearOrFailure = resultScore.result;
        if(clearOrFailure>=clearCount)
        {
            clearOrFailureText.text = "CLEAR";
        }
        else
        {
            clearOrFailureText.text = "FAILURE";
        }

        // if(resultScore.result)

       // PlayerPrefs.SetInt("1st",0);
       // PlayerPrefs.SetInt("2nd",0);
       // PlayerPrefs.SetInt("3rd",0);
       // PlayerPrefs.SetInt("4th",0);
       // PlayerPrefs.SetInt("5th",0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
