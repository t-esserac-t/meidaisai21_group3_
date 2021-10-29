using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeColorOfRadar : MonoBehaviour
{
  public CanAttack canAttack;
    Image radar;
    // Start is called before the first frame update
    void Start()
    {
        radar = GetComponent<Image>();
        radar.color = Color.white;
        bool canAttackTheEnemies = canAttack.canAttackTheEnemies;
    }

    // Update is called once per frame
    void Update()
    {
        bool canAttackTheEnemies = canAttack.canAttackTheEnemies;
        if (canAttackTheEnemies == true)
        {
            this.radar.color = Color.white;
        }
        else
            
        {
            this.radar.color = new Color(1f, 1f, 1f, 0.5f);
        }
    }
}
