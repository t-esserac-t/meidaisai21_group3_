using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        //float型の変数"timer"を作り、0.3をセット
        float timer = 0.3f;
        //自分自身のゲームオブジェクトを0.3待ってから削除
        Destroy(gameObject, timer);
    }
}
