using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public GameObject explosion_prefab;
    public float speed;
   // public bool isAttacked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Vector3.zero);
        transform.position = Vector3.MoveTowards(transform.position,Vector3.zero,speed);
    }
    void OnTriggerEnter(Collider other)
    {
        //接触したオブジェクトのタグが"Player"のとき
        if (other.tag == "Fire")
        {
            Instantiate(explosion_prefab, this.transform.position, Quaternion.identity);
            //thisとは: このスクリプトのこと。this.transform.positionは「このスクリプトがくっついているオブジェクトの位置」の意味
            //Debug.Log("attacked");

            GameObject.Find("GameMain").GetComponent<GameMain>().calcDamage();
            Destroy(this.gameObject);

        }
        else if (other.tag == "Player")
        {
            Destroy(this.gameObject);
                
       
        }
       

    }
}
