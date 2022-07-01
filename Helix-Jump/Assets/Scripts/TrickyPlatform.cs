using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrickyPlatform : MonoBehaviour
{
    private float _duration=3f;
    public Transform target;
    


    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("TrickyPlatform")){

            GameObject otherObj = other.gameObject; 
            otherObj.transform.DOMoveY(target.position.y,_duration);
        }
    }
}
