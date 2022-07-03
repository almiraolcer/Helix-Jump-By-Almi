using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingPlat : MonoBehaviour
{

    [SerializeField]  AudioSource Movesource;
    [SerializeField]  AudioClip  Moveclip;

    private void Start()
    {
        StartCoroutine(RotateCube());
    }
 
    public IEnumerator RotateCube()
    {
        
        while(true){
        yield return new WaitForSeconds(1);
        transform.DORotate(
            transform.eulerAngles + new Vector3(0,20, 0), 1);
         yield return new WaitForSeconds(1);
        transform.DORotate(
            transform.eulerAngles - new Vector3(0,20, 0), 1);
    }
    }


    
        
    }
    
    
    
