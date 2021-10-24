using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorOfView: MonoBehaviour
{
    Image img;
    public CheckAttacked checkAttacked;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        img.color = Color.clear;

        bool isAttacked;
        isAttacked = checkAttacked.isAttacked;
    }

    // Update is called once per frame
    void Update()
    {
        bool isAttacked;
        isAttacked = checkAttacked.isAttacked;
        if (isAttacked==true)
        {
            this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
        }
        else if(isAttacked==false)
        {
            this.img.color = Color.Lerp(this.img.color, Color.clear, Time.deltaTime);
        }

        /*
        bool isAttacked;
        isAttacked = checkAttacked.isAttacked;

        if (isAttacked == true)
        { }
        else
        { }*/

    }

    
}
