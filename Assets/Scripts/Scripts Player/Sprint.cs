using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Sprint : MonoBehaviour
{
    InputAction _sprint;
    public InputActionAsset _inputAA;
    Mouvement _mouvement;
    

    void Awake()
    {
        _sprint = _inputAA.FindActionMap("Default").FindAction("Sprint");
        _mouvement = gameObject.GetComponent<Mouvement>();
    }


    public void OnSprint(InputAction.CallbackContext context)
    {
        if (context.started) { _mouvement._speed *= 2f; }
        if (context.canceled) { _mouvement._speed /= 2f; }
    }
}
