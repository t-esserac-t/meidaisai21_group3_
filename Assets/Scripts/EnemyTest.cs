﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public GameObject explosion_prefab;
    public GameObject damaged_prefab;

 // public CountDown countDown;

    public float speed;
   // public PlayerController playerController;
    // public bool isAttacked;
    // Start is called before the first frame update

    public int armorPoint;
    public int armorPointMax=3;

    private int enemyDamage;
    void Start()
    {
      
            armorPoint = armorPointMax;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Vector3.zero);
        transform.position = Vector3.MoveTowards(transform.position,Vector3.zero,speed);

    }
    void OnTriggerEnter(Collider other)
    {
      // Debug.Log(damage);
        //接触したオブジェクトのタグが"Player"のとき
        if (other.tag == "Fire")
        {
            enemyDamage = GameMain.damage;
            //Debug.Log(countDown.time);
            /*if (countDown.time >= 50)
            { damage = 1; }
            else
            { damage = 3; }*/
            armorPoint -= enemyDamage;
            Instantiate(damaged_prefab, this.transform.position, Quaternion.identity);
            if (armorPoint <= 0)
            {
                Instantiate(explosion_prefab, this.transform.position, Quaternion.identity);
                //thisとは: このスクリプトのこと。this.transform.positionは「このスクリプトがくっついているオブジェクトの位置」の意味
                //Debug.Log("attacked");

                GameObject.Find("GameMain").GetComponent<GameMain>().calcDamage();
                Destroy(this.gameObject);
            }
        }
        else if (other.tag == "Player")
        {
            Destroy(this.gameObject);
                
       
        }
       

    }
}
