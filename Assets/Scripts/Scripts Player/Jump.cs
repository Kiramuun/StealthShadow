using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    InputAction _jump;
    public InputActionAsset _inputAA;
    Mouvement _mouv;
    bool groundedPlayer;
    CharacterController _charactControl;
    Vector3 _position;
    float _jumpHeight = 1f,
          _gravity = -9.81f;

    void Awake()
    {
        _jump = _inputAA.FindActionMap("Default").FindAction("Jump");
        _charactControl = GetComponent<CharacterController>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            /*//transform.Translate(0, 10, 0);
            groundedPlayer = _charactControl.isGrounded;

            if (groundedPlayer)
            {
                _position.y += Mathf.Sqrt(_jumpHeight * -3f * _gravity);
            }
            _position.y += _gravity * Time.deltaTime;
            _charactControl.Move(_position*Time.deltaTime);*/
        }
    }
}
