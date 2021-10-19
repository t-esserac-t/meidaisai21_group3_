using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public int armorPoint;
    public int armorPointMax = 1000;
    int damage = 100;
    public GameObject explosion_prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        armorPoint = armorPointMax;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //接触したオブジェクトのタグが"Player"のとき
        if (other.tag == "Fire" )
        {
            //Instantiate(explosion_prefab, this.transform.position, Quaternion.identity);
            //thisとは: このスクリプトのこと。this.transform.positionは「このスクリプトがくっついているオブジェクトの位置」の意味
            //Debug.Log("attacked");
            //  Destroy(this.gameObject);
            armorPoint -= damage;
            Debug.Log(armorPoint);

            if (armorPoint <= 0)
            {
                Destroy(gameObject);
                Instantiate(explosion_prefab, this.transform.position, Quaternion.identity);
            }
        }
    }
}
