using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    [SerializeField] Vector3 offset = new Vector3(0, 750, -1000);
    public float smoothSpeed = 0.5f; // The smoothness of the camera movement

    private void LateUpdate()
    {
        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position + offset;


        // Smoothly move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera's position
        transform.position = smoothedPosition;
    }

    
}
