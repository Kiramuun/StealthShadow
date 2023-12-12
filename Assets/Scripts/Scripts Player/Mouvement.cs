using System.Collections;
using System.Collections.Generic;
using Cinemachine;
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
            Vector3 z = Camera.main.transform.forward * mouvDir.y;
            Vector3 x = Camera.main.transform.right * mouvDir.x;
            z.y = 0;
            x.y = 0;
            Vector3 dir = (z + x) * _speed * Time.deltaTime;
            
            if (dir.sqrMagnitude > 0) { transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), _speedRotate); }
            _charactControl.Move(dir);
        }
        else
        {
            _velocity.y += _gravity * Time.deltaTime;
            _charactControl.Move(_velocity * Time.deltaTime);
        }
    }

}
