using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingPlat : MonoBehaviour
{


    private void Start()
    {
        StartCoroutine(RotateCube());
    }
 
    public IEnumerator RotateCube()
    {
        
        while(true){
        yield return new WaitForSeconds(1);
        transform.DORotate(
            transform.localRotation.eulerAngles + new Vector3(0,40, 0), 1);
         yield return new WaitForSeconds(1);
        transform.DORotate(
            transform.localRotation.eulerAngles - new Vector3(0,40, 0), 1);
            
    }
    }


    
        
    }
    
    
    
