using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform ball;
    public Vector3 offset;

    [SerializeField] float smoothSpeed = 0.200f;

    void FixedUpdate(){
        Vector3 desiredPosition = ball.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition,smoothSpeed);
        transform.position = smoothedPosition;
    }


}
