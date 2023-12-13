using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsTap : IInputInteraction
{
    public bool _toggled = false;
    
    public void Process(ref InputInteractionContext context)
    {
        /*switch (context.phase)
        {
            case InputActionPhase.Waiting:
                if (context.ControlIsActuated
                break;
        }*/
    }


    void IInputInteraction.Reset()
    {

    }
}
