using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanAttack : MonoBehaviour
{
    public bool canAttackTheEnemies=false;
    // Start is called before the first frame update
    void Start()
    {
        canAttackTheEnemies = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
          canAttackTheEnemies = true;
          //  Debug.Log("enemy!");
           StartCoroutine(switchBoolCanAttack());

        }
        else
        { canAttackTheEnemies = false; }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            canAttackTheEnemies = true;
            //  Debug.Log("enemy!");
            StartCoroutine(switchBoolCanAttack());

        }
        else
        { canAttackTheEnemies = false; }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            canAttackTheEnemies = false;
            //  Debug.Log("enemy!");
            //  StartCoroutine(switchBoolCanAttack());

        }
        else
        {
            canAttackTheEnemies = true;
        }
        
    }




IEnumerator switchBoolCanAttack()
{
    while (canAttackTheEnemies == true)
    {
            // Debug.Log("Enemy has been attacked");

            yield return new WaitForSeconds(0.2f); ;
        canAttackTheEnemies = false;

    }
}

}


