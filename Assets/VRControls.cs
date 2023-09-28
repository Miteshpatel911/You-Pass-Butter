using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class VRControls : MonoBehaviour
{
    private Vector3 input;
    private float turnAmount;
    private float forwardAmount;
    public void Move(Vector3 move, bool jump)
    {
        input = move;
        if (move.magnitude > 1f)
            move.Normalize();

        move = transform.InverseTransformDirection(move);

        turnAmount = Mathf.Atan2(move.x, move.z);
        forwardAmount = move.z;

        //ApplyExtraTurnRotation();

        // control and velocity handling is different when grounded and airborne:
        /*if (isGrounded)
        {
            HandleGroundedMovement(jump);
        }


        // send input and other state parameters to the animator
        UpdateAnimator(move);*/
    }
}
