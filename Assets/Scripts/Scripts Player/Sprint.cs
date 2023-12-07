using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sprint : MonoBehaviour
{
    InputAction _sprint;
    public InputActionAsset _inputAA;

    void Awake()
    {
        _sprint = _inputAA.FindActionMap("Default").FindAction("Sprint");
    }
}
