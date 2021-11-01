using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    public Text rank;
    public Result resultScore;
        int first;
        int second;
        int third;
        int fourth;
        int fifth;
    // Start is called before the first frame update
    void Start()
    {
        int  myScore = (int)resultScore.result;

        first = PlayerPrefs.GetInt("1st", 0);
        second = PlayerPrefs.GetInt("2nd", 0);
        third = PlayerPrefs.GetInt("3rd", 0);
        fourth = PlayerPrefs.GetInt("4th", 0);
        fifth = PlayerPrefs.GetInt("5th", 0);

        if (myScore < fifth)
        { }
        else if ((fifth <= myScore) && (myScore < fourth))
        { PlayerPrefs.SetInt("5th", myScore);
        }
        else if((fourth <= myScore )&& (myScore<third))
        {
            int newFifth = PlayerPrefs.GetInt("4th", 0);
            PlayerPrefs.SetInt("5th", newFifth);
            PlayerPrefs.SetInt("4th", myScore);
        }
        else if (( third <= myScore ) && (myScore < second))
        {
            int newFifth = PlayerPrefs.GetInt("4th", 0);
            int newFourth = PlayerPrefs.GetInt("3rd", 0);
            PlayerPrefs.SetInt("5th", newFifth);
            PlayerPrefs.SetInt("4th", newFourth);
            PlayerPrefs.SetInt("3rd", myScore);
        }
        else if ((second <= myScore ) && (myScore < first))
        {
            int newFifth = PlayerPrefs.GetInt("4th", 0);
            int newFourth = PlayerPrefs.GetInt("3rd", 0);
            int newThird = PlayerPrefs.GetInt("2nd", 0);
            PlayerPrefs.SetInt("5th", newFifth);
            PlayerPrefs.SetInt("4th", newFourth);
            PlayerPrefs.SetInt("3rd", newThird);
            PlayerPrefs.SetInt("2nd", myScore);

        }
        else if  (first<=myScore)
        {
            int newFifth = PlayerPrefs.GetInt("4th", 0);
            int newFourth = PlayerPrefs.GetInt("3rd", 0);
            int newThird = PlayerPrefs.GetInt("2nd", 0);
            int newSecond = PlayerPrefs.GetInt("1st", 0);
            PlayerPrefs.SetInt("5th", newFifth);
            PlayerPrefs.SetInt("4th", newFourth);
            PlayerPrefs.SetInt("3rd", newThird);
            PlayerPrefs.SetInt("2nd", newSecond);
            PlayerPrefs.SetInt("1st", myScore);

        }
        first = PlayerPrefs.GetInt("1st", 0);
        second = PlayerPrefs.GetInt("2nd", 0);
        third = PlayerPrefs.GetInt("3rd", 0);
        fourth = PlayerPrefs.GetInt("4th", 0);
        fifth = PlayerPrefs.GetInt("5th", 0);
        rank.text = ("1st: " + first.ToString() + "\n2nd: " + second.ToString() + "\n3rd: " + third.ToString() + "\n4th: " + fourth.ToString() + "\n5th: " + fifth.ToString());



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
