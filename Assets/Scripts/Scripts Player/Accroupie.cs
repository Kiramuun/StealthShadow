using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Accroupie : MonoBehaviour
{
    InputAction _crouch;
    public InputActionAsset _inputAA;
    
    void Awake()
    {
        _crouch = _inputAA.FindActionMap("Default").FindAction("Crouch");
    }
}
