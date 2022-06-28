using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    Rigidbody rb;
    private float bounceHeight = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Platform")){
            rb.velocity= new Vector3(0,bounceHeight,0);
    
        }
    }


}

