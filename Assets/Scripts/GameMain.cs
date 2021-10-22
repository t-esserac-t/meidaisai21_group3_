using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    public GameObject enemy;

    public int score = 0;
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
    Vector3 zahyou = new Vector3(Random.Range(1.0f, 100.0f), Random.Range(1.0f, 100.0f), Random.Range(1.0f, 100.0f));
    Instantiate(enemy, zahyou, Quaternion.identity);
    yield return new WaitForSeconds(0.3f);
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
