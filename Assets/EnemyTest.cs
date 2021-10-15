using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public GameObject explosion_prefab;

    // Start is called before the first frame update
    void Start()
    {
        
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
            Instantiate(explosion_prefab, this.transform.position, Quaternion.identity);
            //thisとは: このスクリプトのこと。this.transform.positionは「このスクリプトがくっついているオブジェクトの位置」の意味
            //Debug.Log("attacked");
            Destroy(this.gameObject);
            
        }
    }
}
