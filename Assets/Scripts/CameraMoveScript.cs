using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
    //Transform = positions datan
    public Transform target;
    public float followDistance = 0f;
    public float cameraSpeed = 3f;
    public Transform table;

    //Körs efter varje frame
    private void LateUpdate()
    {
        float newRotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * cameraSpeed;
        float newRotationY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * cameraSpeed;

        Vector3 desiredRotation = new Vector3( newRotationY, newRotationX, 0f);
        Vector3 desiredTargetRotation = new Vector3(0f, newRotationX, 0f);

        transform.localEulerAngles = desiredRotation;
        target.localEulerAngles = desiredTargetRotation;

        //The players "forward" is the cameras "forward"
        //In other words, you look left, the character model moves left (in x-axis)
        //target.forward = transform.forward;

        float positionY = target.position.y + 1;
        float positionX = target.position.x;
        float positionZ = target.position.z;

        //if i ever need the other line of code for target position:
        //Vector3 desiredPosition = target.position - transform.forward * followDistance;

        Vector3 desiredHeadLevel = new Vector3 ( positionX, positionY, positionZ);

        
        transform.position = desiredHeadLevel;
    }
}
