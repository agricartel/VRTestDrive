﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    public Camera cam;


    // Use this for initialization
    void Start () {
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Vector3 MousePos()
    {
        return cam.ScreenToWorldPoint(Input.mousePosition);
    }
}
