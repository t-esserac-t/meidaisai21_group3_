using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    public GameObject enemy;
   // public EnemyTest enemyTest;
    public bool isAttacked;
    public int score = 0;
    public CountDown countDown;

    public static int damage;
    public float timeOfOffensivePowerIncreased;
    public float timeOfMouseSensitivityIncreased;
    public float timeOfCollisionDetectionExpanded;
    public float timeOfAutoAimable;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
        StartCoroutine(waki());
        //Instantiate(explosion_prefab, this.transform.position, Quaternion.identity);
    }

IEnumerator waki()
    {

        while (true)
        {
            float theta = Random.Range(0f, Mathf.PI);
            float phi = Random.Range(0f, 2 * Mathf.PI);
            float radius = Random.Range(7.0f,30.0f);
            Vector3 zahyou = new Vector3(radius * Mathf.Cos(theta) * Mathf.Cos(phi), radius * Mathf.Cos(theta) * Mathf.Sin(phi), radius * Mathf.Sin(theta));
            Instantiate(enemy, zahyou, Quaternion.identity);
           if(countDown.time<=timeOfOffensivePowerIncreased)
           {
                damage = 3; 
           }
            else
           {
               damage = 1;
           }
            enemy.gameObject.tag = "Enemy";
            if(countDown.time<=10)
            { yield return new WaitForSeconds(0.1f);
            }
            else if ((10<countDown.time)&&(countDown.time <= 45))
            {
                yield return new WaitForSeconds(0.5f);
            }
            else
            {
                yield return new WaitForSeconds(1f);
            }
            /* Vector3 zahyou = new Vector3(Random.Range(1.0f, 100.0f), Random.Range(1.0f, 100.0f), Random.Range(1.0f, 100.0f));
             Instantiate(enemy, zahyou, Quaternion.identity);
             yield return new WaitForSeconds(0.3f);*/
        }
}
// Update is called once per frame
void Update()
    {
        
    }
    public void calcDamage()
    {
        score++;
        PlayerPrefs.SetInt("score", score);
    }
}
