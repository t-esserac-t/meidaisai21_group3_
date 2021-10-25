using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ClearOrFailed : MonoBehaviour
{
    public Result resultScore;
   private int handan;
    //public float clearOrFailure;
    public Text clearOrFailureText; 

    // Start is called before the first frame update
    void Start()
    {
        float clearOrFailure = resultScore.result;
        handan = GameSystem.fixedClearCount;
        Debug.Log("handan: " + handan);
        Debug.Log("in result scene, fixedClearCount is " + GameSystem.fixedClearCount);
        Debug.Log(handan);
        if(clearOrFailure>=handan)
        {
            Debug.Log("handan is"+handan);
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
