using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueText : MonoBehaviour
{

    public PlayerController playerController;
    public Text dialogue;
   // public Color opacityOfDialogue = Color.white;
    //関数を呼ぶたびに↑こいつをwhiteにする
    bool isSensitivityIncreasedMentioned = false;
    bool isOffensivePowerMentioned = false;
  //  Animator animator;

    public GameMain gameMain;
    public CountDown countDown;
    // Start is called before the first frame update
    void Start()
    {
        //animator = this.gameObject.GetComponent<Animator>();
        dialogue.color = Color.white;
        dialogue.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        int number = GameMain.roundCount;
        switch (number)
        {
            case 0:
                dialogue.text = "";
                break;
            case 1:
                dialogue.text = "Mouse sensitivity increased.";
                break;
            case 2:
                dialogue.text = "Mouse sensityvity increased.\nOffensive power increased.";
                break;
            case 3:
                dialogue.text = "Mouse sensityvity increased.\nOffensive power increased.\nHit detection expanded.";
                break;
            case 4:
                dialogue.text = "Mouse sensityvity increased.\nOffensive power increased.\nHit detection expanded.\nAuto aimable.";
                break;
        }

    }
}
        //if ((countDown.time <= gameMain.timeOfMouseSensitivityIncreased) && (countDown.time >= gameMain.timeOfMouseSensitivityIncreased - 2.3f))
        //{
        //  StartCoroutine(animation("Mouse sensitivity increased."));
        //animator.enabled = false;
        //}
        // animateDialogue("Offensive power increased.");
        //animateDialogue("Collision detection expanded.");
        //animateDialogue("Auto aimable.");


/*&& ( gameMain.timeOfMouseSensitivityIncreased<= countDown.time + 2.3f))*/
//  {
//float count = 0;
// while (count <= 2000)
///  {

//dialogue.text = ("Mouse sensitivity increased.");
//animator.Play("DialogueAnimation");


// isSensitivityIncreasedMentioned = true;
// }
// dialogue.text = ("");
//}
/*else
{
    animator.enabled = false ;
   /* if ((countDown.time <= gameMain.timeOfOffensivePowerIncreased)
&& (countDown.time >= gameMain.timeOfOffensivePowerIncreased - 2.3f))
    {
        //float count = 0;
        // while (count <= 2000)
        ///  {
        dialogue.text = ("Offensive power increased.");
        animator.Play("DialogueAnimation");
        // isSensitivityIncreasedMentioned = true;
        // }
        // dialogue.text = ("");
    }
    else
    {
        animator.enabled = false;
 }   
 */






/*
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
    void animateDialogue(string dlg)
    {
        animator.enabled = true;
        dialogue.text = dlg;

        animator.Play("DialogueAnimation");

    }
    IEnumerator animation(string dlg)
    {
        animator.enabled = true;
        dialogue.text = dlg;
        animator.Play("DialogueAnimation");
        yield return new WaitForSeconds(2.3f);
    }
        
        
        //COCO追加分(文字ちかちかアニメーション終了時）
    public void EndAnim()
    {
        //        animateDialogue("");
        animator.enabled = false;
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
    

    Color ChangeColorOfDialogue(string dlg,Color c)
    {
        dialogue.text = dlg;
        c = Color.Lerp(c, Color.clear,0.01f);
        //  Debug.Log("aa");
       // Debug.Log(dialogue.color);
        return c;
    }
    */

