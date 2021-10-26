using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueText : MonoBehaviour
{
   
    public PlayerController playerController;
    public Text dialogue;
    //public Color opacityOfDialogue=Color.white;
    //関数を呼ぶたびに↑こいつをwhiteにする
    bool isSensitivityIncreasedMentioned=false;
    bool isOffensivePowerMentioned = false;

    // Start is called before the first frame update
    void Start()
    {
        dialogue.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
     if ((playerController.sensitivity >= 3) &&(isSensitivityIncreasedMentioned == false))
      {
            // dialogue.color = Color.white;
            // StartCoroutine(HALDialogue("Mouse sensitivity increased."));
            // isSensitivityIncreased = true;
            // Debug.Log("HAL");
            if (dialogue.color.a >=0.05 )
            {
                dialogue.color = ChangeColorOfDialogue("Mouse sensitivity increased.", dialogue.color);
            }
           else
           {
                dialogue.color = Color.white;
                dialogue.text = "";
                isSensitivityIncreasedMentioned = true;
            }
      }

     if((GameMain.damage==3)&&(isOffensivePowerMentioned==false))
        {
            if (dialogue.color.a >= 0.05)
            {
                dialogue.color = ChangeColorOfDialogue("Offensive power increased.", dialogue.color);
            }
            else
            {
                dialogue.color = Color.white;
                dialogue.text = "";
                isOffensivePowerMentioned = true;
            }

        }
    }

    /*
    IEnumerator HALDialogue(string dlg, color cl)
    {
        dialogue.text = dlg;
        dialogue.color = Color.Lerp(dialogue.color, Color.clear, 0.1f);
        Debug.Log("AA");
        //dialogue.text = "";
        //dialogue.color = Color.white;
        yield return new WaitForSeconds(1f);

    }
    */

    Color ChangeColorOfDialogue(string dlg,Color c)
    {
        dialogue.text = dlg;
        c = Color.Lerp(c, Color.clear,0.01f);
        //  Debug.Log("aa");
       // Debug.Log(dialogue.color);
        return c;
    }
}
