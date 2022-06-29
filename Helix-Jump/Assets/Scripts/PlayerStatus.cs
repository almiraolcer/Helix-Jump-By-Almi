using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour
{

    public GameObject RestartMenu;
    public GameObject FinishMenu;
    private Rigidbody _rb;

    [SerializeField]  AudioSource _Trapsource;
    [SerializeField]  AudioClip  _Trapclip;

    [SerializeField]  AudioSource _Winsource;
    [SerializeField]  AudioClip  _Winclip;


    private void Start() {
        _rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Trap")){
            _rb.isKinematic = true;
            _Trapsource.PlayOneShot(_Trapclip);
            RestartMenu.SetActive(true);

        }
        else if(other.gameObject.CompareTag("FinishLine")){
            _Winsource.PlayOneShot(_Winclip);
            FinishMenu.SetActive(true);
            _rb.isKinematic = true;

        }

    }

    public void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel(){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit(){
        Application.Quit();
    }


    
   
}
