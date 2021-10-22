using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;

   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }

    void Shot() 
    {
        //GameObject型の「obj」を作る
        GameObject obj;
        //"obj"に"bullet"のインスタンスをセットする(クローン)
        obj = GameObject.Instantiate(bullet);
        //「obj」の位置座標に今の「Muzzle」の位置座標をセットする
        obj.transform.position = transform.position;
        //「obj」のRigidbody(重力)に、今の「Muzzle」のz軸方向に1000をかけたパワーを加える
        obj.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);


    }
}
