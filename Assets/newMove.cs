using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class newMove : MonoBehaviour
{
    public Camera cam;

    public MouseLook mouseLook;

    // Start is called before the first frame update
    void Start()
    {
        mouseLook = new MouseLook();
    }

    // Update is called once per frame
    void Update()
    {
        RotateView();
    }

    private void CameraRotation()
    {
        /*
        // if there is an input
        if (_input.look.sqrMagnitude >= _threshold)
        {
            _cinemachineTargetPitch += _input.look.y * RotationSpeed * Time.deltaTime;
            _rotationVelocity = _input.look.x * RotationSpeed * Time.deltaTime;

            // clamp our pitch rotation
            _cinemachineTargetPitch = ClampAngle(_cinemachineTargetPitch, BottomClamp, TopClamp);

            // Update Cinemachine camera target pitch
            CinemachineCameraTarget.transform.localRotation = Quaternion.Euler(_cinemachineTargetPitch, 0.0f, 0.0f);

            // rotate the player left and right
            transform.Rotate(Vector3.up * _rotationVelocity);
        }
        */
    }
    private void RotateView()
    {
        //avoids the mouse looking if the game is effectively paused
        if (Mathf.Abs(Time.timeScale) < float.Epsilon) return;

        // get the rotation before it's changed
        float oldYRotation = transform.eulerAngles.y;

        mouseLook.LookRotation(transform, cam.transform);

        
            // Rotate the rigidbody velocity to match the new direction that the character is looking
            Quaternion velRotation = Quaternion.AngleAxis(transform.eulerAngles.y - oldYRotation, Vector3.up);
            //m_RigidBody.velocity = velRotation * m_RigidBody.velocity;
        
    }
}
