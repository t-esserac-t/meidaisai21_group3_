﻿//PlayerController.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject Player;
    public GameObject Camera;
    public float speed;
    private Transform PlayerTransform;
    private Transform CameraTransform;
    public GameObject attack;
    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

        PlayerTransform = transform.parent;
        CameraTransform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
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
        if (Input.GetKey(KeyCode.A))
        {
            PlayerTransform.transform.Rotate(0, -90 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerTransform.transform.Rotate(0,90*Time.deltaTime,0);
        }
        if (Input.GetMouseButtonDown(0))
        {

            StartCoroutine(Shot());
        }
        float X_Rotation = Input.GetAxis("Mouse Y");
        PlayerTransform.transform.Rotate(-X_Rotation*8, 0, 0);
    }
    

    IEnumerator Shot()
    {
        attack.SetActive(true);
        audioSource.Play();
        yield return new WaitForSeconds(0.3f);
        attack.SetActive(false);
    }
}