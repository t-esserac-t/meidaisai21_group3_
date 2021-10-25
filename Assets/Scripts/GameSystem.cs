using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public InputField timeCount;
    public InputField clearCount;
    public InputField enemySpawn;
    public InputField enemyEndurance;
    public InputField enemySpeed;

    public static float fixedTimeCount;
    public static int fixedClearCount=10;
    public static float fixedEnemySpawn;
    public static int fixedEnemyEndurance;
    public static float fixedEnemySpeed;

    void Start()
    {
        fixedTimeCount = 20f;
       // fixedClearCount = 10;
        fixedEnemySpawn = 1.0f;
        fixedEnemyEndurance = 3;
        fixedEnemySpeed = 0.005f;
        Debug.Log("GameSystem's Start() is called");
        //PlayerPrefs.SetInt("clearCount", 1);
        //timeCount = GetComponent < InputField >
        /*  PlayerPrefs.DeleteAll();
          PlayerPrefs.SetFloat("timeCount", 20f);
          PlayerPrefs.SetInt("clearCount", 10);
          PlayerPrefs.SetFloat("enemySpawn", 1.0f);
          PlayerPrefs.SetInt("enemyEndurance", 3);
          PlayerPrefs.SetFloat("enemySpeed", 0.05f);
          */
    }
   public void StartGame()
    {
        if (timeCount.text != "")
        {
            fixedTimeCount = float.Parse(timeCount.text);
            //PlayerPrefs.SetFloat("timeCount", float.Parse(timeCount.text));
        }
        else
        {
            fixedTimeCount = 20f;

        }
        //else { PlayerPrefs.SetFloat("timeCount", 20f); }

        if (clearCount.text != "")
        {
           fixedClearCount = int.Parse(clearCount.text);
           // Debug.Log("in title scene, fixedClearCount is " + fixedClearCount);
           //PlayerPrefs.SetInt("clearCount", int.Parse(clearCount.text));
        }
       else
        {
            fixedClearCount = 10;
           
        }

        if (enemySpawn.text != "")
        {
            fixedEnemySpawn = float.Parse(enemySpawn.text);
            //PlayerPrefs.SetFloat("enemySpawn", float.Parse(enemySpawn.text));
        }
        else
        {
            fixedEnemySpawn = 1.0f;
             }
        
        if (enemyEndurance.text != "")
        {
            fixedEnemyEndurance = int.Parse(enemyEndurance.text);
            //PlayerPrefs.SetInt("enemyEndurance", int.Parse(enemyEndurance.text));
            // Debug.Log("enemyEndurance is cast");
        }
        else {
            fixedEnemyEndurance = 3;
           
        }
        // else { PlayerPrefs.SetInt("enemyEndurance", 3); }

        if (enemySpeed.text != "")
        {
            fixedEnemySpeed = float.Parse(enemySpeed.text);
            //PlayerPrefs.SetFloat("enemySpeed", float.Parse(enemySpeed.text));
        }
        else { fixedEnemySpeed = 0.005f; }
       // else { PlayerPrefs.SetFloat("enemySpeed", 0.05f); }

        //Debug.Log("timeCount:::::::::" + PlayerPrefs.GetFloat("timeCount", 0));
        SceneManager.LoadScene ("test");
    }/*
    public void GoToResult()
    {
        SceneManager.LoadScene("Result");
    }*/
    public void BackToTitle()
    {/*
        PlayerPrefs.SetFloat("timeCount", 20f);
        PlayerPrefs.SetInt("clearCount", 10);
        PlayerPrefs.SetFloat("enemySpawn", 1.0f);
        PlayerPrefs.SetInt("enemyEndurance", 3);
        PlayerPrefs.SetFloat("enemySpeed", 0.05f);*/
       // PlayerPrefs.SetInt("clearCount", 10);
        SceneManager.LoadScene("Title");
    }
    public void EndGame()
    {/*
        PlayerPrefs.SetFloat("timeCount", 20f);
        PlayerPrefs.SetInt("clearCount", 10);
        PlayerPrefs.SetFloat("enemySpawn", 1.0f);
        PlayerPrefs.SetInt("enemyEndurance", 3);
        PlayerPrefs.SetFloat("enemySpeed", 0.05f);
        */
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
    Application.OpenURL("http://sokon.jp/");
#else
        Application.Quit();
#endif
    }
    
}
