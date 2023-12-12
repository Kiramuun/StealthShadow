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

    public void OnMarche(InputAction.CallbackContext context)
    {
        if (context.started) { _mouvement._speed /= 2.5f; }
        if (context.canceled) { _mouvement._speed *= 2.5f; }
    }
}
