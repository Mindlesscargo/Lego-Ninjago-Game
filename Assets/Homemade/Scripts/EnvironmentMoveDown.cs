using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnvironmentMoveDown : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Transform thisTransform = this.transform;
        Vector3 newPosition = thisTransform.position;

        if (thisTransform.position.y <= -130)
        {
            newPosition.y = 230;
        }
        else
        {
            newPosition.y -= 1;
        }
        rb.MovePosition(newPosition);
    }
}
