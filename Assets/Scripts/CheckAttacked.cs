using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAttacked : MonoBehaviour
{
    public bool isAttacked;

    void Start()
    {
        isAttacked = false;
    }

    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            isAttacked = true;
             StartCoroutine(switchBoolIsAttacked());
            
        }
    }
IEnumerator switchBoolIsAttacked()
{
    while (isAttacked == true)
    {
        // Debug.Log("Enemy has been attacked");

        yield return new WaitForSeconds(1f);
        isAttacked = false;

    }
}

}

