using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouvement : MonoBehaviour
{
    public InputAction _mouv,
                       _jump;
    [SerializeField] float _speed,
                           _gravity = -7.5f;
    Vector3 _velocity;

    void Start()
    {
        _mouv.Enable();
    }

    void Update()
    {
        var mouvDir = _mouv.ReadValue<Vector2>();
        Vector3 dir = new Vector3(mouvDir.x, 0, mouvDir.y) * _speed * Time.deltaTime;
        CharacterController _charactControl = GetComponent<CharacterController>();
        _charactControl.Move(dir);

        if (!_charactControl.isGrounded)
        {
            _velocity.y += _gravity * Time.deltaTime;
            _charactControl.Move(_velocity * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        
    }
}
