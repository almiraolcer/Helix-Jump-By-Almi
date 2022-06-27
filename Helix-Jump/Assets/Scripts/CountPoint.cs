using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CountPoint : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _PointsText;
    private int points=0;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Invisible")){
            points+=5;
            _PointsText.text = "" + points;

        }

    }
  

}
