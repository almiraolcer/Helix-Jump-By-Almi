using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintSplash : MonoBehaviour
{
    [SerializeField] private GameObject _PaintSplashPrefab;
    private float _destroyTime = 1.5f;


        void OnCollisionEnter(Collision other){
                RaycastHit hitInfo;
                if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hitInfo)){
                    GameObject obj = Instantiate(_PaintSplashPrefab, hitInfo.point, _PaintSplashPrefab.transform.rotation);
                    obj.transform.SetParent(other.gameObject.transform);
                    obj.transform.position += obj.transform.TransformDirection(Vector3.back)/1000;
                    Destroy(obj, _destroyTime);
                }
                }
            }
        
    

