using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Marche : MonoBehaviour
{
    InputAction _marche;
    public InputActionAsset _inputAA;

    void Awake()
    {
        _marche = _inputAA.FindActionMap("Default").FindAction("Marche");
    }
}
