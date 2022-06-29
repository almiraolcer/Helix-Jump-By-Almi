using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CountPoint : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _PointsText;
    private int points=0;

    [SerializeField]  AudioSource _Ringsource;
    [SerializeField]  AudioClip  _Ringclip;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Invisible")){
            points+=5;
            _PointsText.text = "" + points;
            _Ringsource.PlayOneShot(_Ringclip);

        }

    }
  

}
