using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour
{

    PlayerInput playerinput;
    Vector3 inputdirection;
    private float _rotationSpeed = 80f;

    private void Awake() {
        
        playerinput = new PlayerInput();

        playerinput.CylinderControl.Rotation.performed += x  => RotateCylinder(x.ReadValue<Vector2>());
        playerinput.CylinderControl.Rotation.canceled += x  => RotateCylinder(x.ReadValue<Vector2>());
    }

    void RotateCylinder(Vector2 val){

       inputdirection = new Vector3(0 , val.x , 0);
        

    }

    private void Update() {

        transform.Rotate(inputdirection * Time.deltaTime * _rotationSpeed);
        
    }

    private void OnEnable(){
    playerinput.CylinderControl.Enable();

    }

    private void OnDisable(){
    playerinput.CylinderControl.Disable();
        
    }
}

