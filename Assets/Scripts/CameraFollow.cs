//Grga
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] 
    private Transform player;//The target to follow.
    [SerializeField]
    private float smoothSpeed = 5f;//At what rate the camera should move towards the target.
    [SerializeField]
    private Vector3 offset;//Offset for the camera.
    [SerializeField]
    private bool tiltCamera;//tilt the camera after the player?

    private void FixedUpdate ()
    {
        Vector3 desiredPosition = player.position + offset;//The desired position of the camera.
        Vector3 smoothedPositions = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);//Moves the camera towards the players slower.
        transform.position = smoothedPositions;
        if(tiltCamera)
        { 
            transform.LookAt(player);//Always looks at the player.
        }
    }
}