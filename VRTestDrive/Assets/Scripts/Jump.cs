using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    Vector3 jumpHeight = new Vector3(0.0f, 0.2f, 0.0f);

    // Use this for initialization
    void Start () {
    
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Jump")) {
            transform.position += jumpHeight;
        }
	}
}
