using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Target型の"target"を作る

    Target target;
    // Start is called before the first frame update
   void Start()
    {
        target = GameObject.Find("Target").GetComponent<Target>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void OnCollisionEnter(Collision col)
    {
        //もしぶつかったときのオブジェクトのタグが"Target"だったら
        if(col.gameObject.tag == "Target")
        {
            target.Damage();
            Destroy(gameObject);
        }
    }
}
