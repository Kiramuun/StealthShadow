using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    InputAction _jump;
    public InputActionAsset _inputAA;

    void Awake()
    {
        _jump = _inputAA.FindActionMap("Default").FindAction("Jump");
    }
}
