using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandCollisionDetection : MonoBehaviour
{
    public CountDown countDown;
    public Vector3 collisionDetection=new Vector3(1,1,1);
    public GameMain gameMain;
    // Start is called before the first frame update
    void Start()
    {
        collisionDetection.z = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(countDown.time<=gameMain.timeOfCollisionDetectionExpanded)
        {
            collisionDetection.z = 3; 
        }
        else
        {
            collisionDetection.z = 1;
        }

        this.transform.localScale=collisionDetection;
      //  Debug.Log(countDown.time);
    }
}
