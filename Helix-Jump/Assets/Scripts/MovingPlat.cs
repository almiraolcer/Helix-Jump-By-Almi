using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingPlat : MonoBehaviour
{

    private Vector3 _temp;
    private void Start()
    {
       Vector3 _temp = transform.rotation.eulerAngles;
        StartCoroutine(RotateCube(_temp));
    }
 
  
    public IEnumerator RotateCube(Vector3 _temp)
    {
        while(true){
       transform.DOLocalRotate(
            _temp + new Vector3(0, 90, 0) , 3f);
        yield return new WaitForSeconds(1);
        transform.DOLocalRotate(
            _temp - new Vector3(0, 90, 0) , 3f);
        yield return new WaitForSeconds(1);
         }
    
    }  
    }
    
    
    
