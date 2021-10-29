using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RotationText : MonoBehaviour
{
    public PlayerController playerController;
    public Text rotationText;
    private UnityEngine.Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(playerController.transform.rotation);
        rot = playerController.transform.rotation;

        rotationText.text="Quaternion\n"+rot.ToString();
    }
}
