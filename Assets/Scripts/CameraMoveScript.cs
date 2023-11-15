using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
    //Transform = positions datan
    public Transform target;
    public float followDistance = 0f;
    public float cameraSpeed = 3f;
    public Transform targetEyes;

    //Körs efter varje frame
    private void LateUpdate()
    {

        float newRotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * cameraSpeed;
        float newRotationY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * cameraSpeed;

        Vector3 desiredRotation = new Vector3( newRotationY, newRotationX, 0f);
        transform.localEulerAngles = desiredRotation;

        //The players "forward" is the cameras "forward"
        //In other words you look forward and the character model follows
        target.forward = transform.forward;

        Vector3 desiredPosition = target.position - transform.forward * followDistance;
        transform.position = desiredPosition;
    }
}
