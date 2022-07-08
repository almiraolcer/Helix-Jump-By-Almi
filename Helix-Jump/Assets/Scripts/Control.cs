using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour
{

    private PlayerInput _playerinput;
    private Vector3 _inputdirection;
    private float _rotationSpeed = 80f;

    private void Awake() {
        
        _playerinput = new PlayerInput();

        _playerinput.CylinderControl.Rotation.performed += x  => RotateCylinder(x.ReadValue<Vector2>());
        _playerinput.CylinderControl.Rotation.canceled += x  => RotateCylinder(x.ReadValue<Vector2>());
    }

    void RotateCylinder(Vector2 val){

       _inputdirection = new Vector3(0 , val.x , 0);
        

    }

    private void Update() {

        transform.Rotate(_inputdirection * Time.deltaTime * _rotationSpeed);
        
    }

    private void OnEnable(){
    _playerinput.CylinderControl.Enable();

    }

    private void OnDisable(){
    _playerinput.CylinderControl.Disable();
        
    }
}

