using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{

    

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Invisible")){
            Debug.Log("hit.");
            var parentGameObject = other.transform.parent.gameObject;
            StartCoroutine(RemoveRing(parentGameObject));
            //parentGameObject.GetComponentInChildren<Renderer>().material.DOColor(Color.white,1f);               
            //parentGameObject.transform.DOMoveY(1f,5f);       
        }
    }

    IEnumerator RemoveRing(GameObject obj){
            yield return new WaitForSeconds(0.5f);
            obj.SetActive(false);
    }
}


