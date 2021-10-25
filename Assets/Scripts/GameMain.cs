using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    public GameObject enemy;
    public bool isAttacked;
    public int score = 0;
    public float wait;
 /*
    public float fixedTimeCount=20f;
    public int fixedClearCount=10;
    public float fixedEnemySpawn=1.0f;
    public int fixedEnemyEndurance=3;
    public float fixedEnemySpeed=0.05f;
    */

    // Start is called before the first frame update
    void Start()
    {
        /*fixedTimeCount=PlayerPrefs.GetFloat("timeCount",20f);
        fixedClearCount = PlayerPrefs.GetInt("clearCount", 10);
        fixedEnemySpawn = PlayerPrefs.GetFloat("enemySpawn", 1.0f);
        fixedEnemyEndurance = PlayerPrefs.GetInt("enemyEndurance", 3);
        fixedEnemySpeed = PlayerPrefs.GetFloat("enemySpeed", 0.05f);
        */
        //Debug.Log(GameSystem.fixedClearCount);
        wait = GameSystem.fixedEnemySpawn;
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
            enemy.gameObject.tag = "Enemy";
            yield return new WaitForSeconds(wait);

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
