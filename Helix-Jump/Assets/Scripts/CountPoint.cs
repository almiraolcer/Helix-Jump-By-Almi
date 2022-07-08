using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CountPoint : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _PointsText;
    private int _points=0;

    [SerializeField] private AudioSource _Ringsource;
    [SerializeField] private AudioClip  _Ringclip;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Invisible")){
            _points+=5;
            _PointsText.text = "" + _points;
            _Ringsource.PlayOneShot(_Ringclip);

        }

    }
  

}
