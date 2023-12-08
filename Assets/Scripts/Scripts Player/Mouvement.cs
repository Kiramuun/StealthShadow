using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouvement : MonoBehaviour
{
    private InputAction _mouv;
    public InputActionAsset _inputAA;

    public float _speed,
                 _speedRotate = 0.1f,
                 _gravity;
    Vector3 _velocity;
    CharacterController _charactControl;

    void Awake()
    {
        _charactControl = GetComponent<CharacterController>();
        _mouv = _inputAA.FindActionMap("Default").FindAction("Mouv");
        _mouv.Enable();
    }

    void Update()
    {
        if (_charactControl.isGrounded)
        {
            var mouvDir = _mouv.ReadValue<Vector2>();
            Vector3 dir = new Vector3(mouvDir.x, 0, mouvDir.y) * _speed * Time.deltaTime;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), _speedRotate);
            _charactControl.Move(dir);
        }
        else
        {
            _velocity.y += _gravity * Time.deltaTime;
            _charactControl.Move(_velocity * Time.deltaTime);
        }
    }

}
