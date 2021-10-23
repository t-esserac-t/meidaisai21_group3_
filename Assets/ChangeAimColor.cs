using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAimColor : MonoBehaviour
{
    public Check check;
    public Image aim;
    void Start()
    {}
    void Update()
    {
        bool canAttack = check.canAttack;
        if (canAttack == true)
        {
            aim.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else if(canAttack==false)
        {
            aim.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }
}
/*

     ChangeAimColor changeAimColor = new ChangeAimColor();
     bool canAttack = check.canAttack;
     //GameObject.Find("GameMain").GetComponent<GameMain>().calcDamage();
     if (canAttack == true)
     {
         changeAimColor.aim.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
     }
     else
     {
         changeAimColor.aim.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
     }
     */
