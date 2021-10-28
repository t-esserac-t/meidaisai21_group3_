//PlayerController.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerController : MonoBehaviour
{
    public CheckAttacked checkAttacked;

    AudioSource audioSource;
    public GameObject Player;
    public GameObject Camera;
    public float speed;
    private Transform PlayerTransform;
    private Transform CameraTransform;
    public GameObject attack;

    public AudioClip shot;
    public AudioClip cantShot;

    public CountDown countDown;

    public float sensitivity;
    public int damage;
    public GameMain gameMain;
    GameObject target = null;
    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

        PlayerTransform = transform.parent;
        CameraTransform = GetComponent<Transform>();

       bool isAttacked;
        isAttacked = checkAttacked.isAttacked;
        Cursor.visible = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        bool isAttacked;
        isAttacked = checkAttacked.isAttacked;
        /*
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        PlayerTransform.transform.Rotate(0, X_Rotation, 0);
        CameraTransform.transform.Rotate(-Y_Rotation, 0, 0);


        float angleDir = PlayerTransform.transform.eulerAngles.y * (Mathf.PI / 180.0f);
        Vector3 dir1 = new Vector3(Mathf.Sin(angleDir), 0, Mathf.Cos(angleDir));
        Vector3 dir2 = new Vector3(-Mathf.Cos(angleDir), 0, Mathf.Sin(angleDir));


        if (Input.GetKey(KeyCode.W))
        {
            PlayerTransform.transform.position += dir1 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerTransform.transform.position += dir2 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerTransform.transform.position += -dir2 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayerTransform.transform.position += -dir1 * speed * Time.deltaTime;
        }
        */
        /* if (Input.GetKey(KeyCode.A))
        {
            PlayerTransform.transform.Rotate(0, -90 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerTransform.transform.Rotate(0,90*Time.deltaTime,0);
        }
        */

        if (Input.GetMouseButtonDown(0))
        {
            if (isAttacked == false)
            {
                StartCoroutine(Shot());
            }
            else
            { 
                     audioSource.PlayOneShot(cantShot);
            }
        }
        
        if (countDown.time >=gameMain.timeOfMouseSensitivityIncreased)
        {
            sensitivity = 2;
        }
        else
        {
            sensitivity = 6;
        }
        //if (countDown.time >= 30)
        //{
          
        /*}
        else
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        }
        */

        damage = GameMain.damage;

      /*  if(countDown.time<= timeOfOffensivePowerIncreased)
        { damage = 3; }
        else { damage = 1; }*/

        if(countDown.time<=gameMain.timeOfAutoAimable)
        {
            target = FindClosestEnemy();
            transform.LookAt(target.transform);
            // Debug.Log(tagEnemies.transform.position.Min());
        }
        else
        {
            float X_Rotation = Input.GetAxis("Mouse Y");
            PlayerTransform.transform.Rotate(-X_Rotation * sensitivity, 0, 0);
            float Y_Rotation = Input.GetAxis("Mouse X");
            PlayerTransform.transform.Rotate(0, Y_Rotation * sensitivity, 0);
        }
    }

    GameObject FindClosestEnemy()
    {
        GameObject[] enemies;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        //Vector3 position = Vector3.zero;
        foreach(GameObject enm in enemies)
        {
            Vector3 diff = enm.transform.position;
            float curDistance = diff.sqrMagnitude;

            if(curDistance<distance)
            { closest = enm;
                distance = curDistance;
            }
        }
        return closest;
    }

    IEnumerator Shot()
    {
        attack.SetActive(true);
        audioSource.PlayOneShot(shot);
        yield return new WaitForSeconds(0.05f);
        attack.SetActive(false);
    }
}