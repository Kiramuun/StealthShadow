using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Marche : MonoBehaviour
{
    InputAction _marche;
    public InputActionAsset _inputAA;
    Mouvement _mouvement;

    void Awake()
    {
        _marche = _inputAA.FindActionMap("Default").FindAction("Marche");
        _mouvement = gameObject.GetComponent<Mouvement>();
    }

    void Update()
    {
        /*if (_marche != null) { _mouvement._speed /= 2f; }
        else { _mouvement._speed *= 2f; }*/
    }
}
