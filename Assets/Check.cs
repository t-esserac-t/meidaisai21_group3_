using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    public bool canAttack;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        if(other.tag=="Enemy")
        {
            canAttack = true;
           
        }
        else
        {
            canAttack = false;
        }
    }

}
