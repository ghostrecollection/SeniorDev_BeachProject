using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputManagerEntry;

public class InputManager : MonoBehaviour
{
    public Vector2 move;
    public bool jump;
    public bool sprint;


    // OnMove Function through Input System
    void OnMove(InputValue value)
    {
        // Move Inputs on x and z
        move = value.Get<Vector2>();
    }

    // OnSprint Function through Input System
    void OnSprint(InputValue value)
    {
        sprint = value.isPressed;
    }

    // OnJump Function through Input System
    void OnJump(InputValue value)
    {
        jump = value.isPressed;

    }




}
