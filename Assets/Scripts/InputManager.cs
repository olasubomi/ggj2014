﻿using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    public static float HorizAxis;
    public static bool JumpDown;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        HorizAxis = Input.GetAxis("Horizontal");
        JumpDown = Input.GetButtonDown("Jump");
	}
}
