using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Accroupie : MonoBehaviour
{
    InputAction _crouch;
    public InputActionAsset _inputAA;
    public MeshRenderer _renderer;
    public Color _color;
    
    void Awake()
    {
        _crouch = _inputAA.FindActionMap("Default").FindAction("Crouch");
    }

    public void OnSneak(InputAction.CallbackContext context)
    {
        if (context.started) { _renderer.material.color = Color.red; }
        if (context.canceled) { _renderer.material.color = _color; }
    }

}
