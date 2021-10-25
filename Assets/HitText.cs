using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HitText : MonoBehaviour
{
    public GameMain gameMain;
    //public ClearOrFailed clearOrFailed;

    public Text hitText;

    // Start is called before the first frame update
    void Start()
    {
        }

    // Update is called once per frame
    void Update()
    {
        if (gameMain.score != null)
        {
            hitText.text = gameMain.score + " / " + ClearOrFailed.clearCount.ToString();
        }
        else
        {
            hitText.text="0 / "+ ClearOrFailed.clearCount.ToString();
        }
    
    }
}
