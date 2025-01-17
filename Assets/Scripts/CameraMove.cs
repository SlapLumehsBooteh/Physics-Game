﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float FollowSpeed = 120f;
    public Transform Target;
    private void Start()
    {

    }
    private void Update()
    {
        //This controls the camera so that it follows the crate while ignoring the rotation of the crate
        Vector3 newPosition = Target.position;
        newPosition.z = -10;
        transform.position = Vector3.Slerp(transform.position, newPosition, FollowSpeed * 4.5f * Time.deltaTime);
    }
}