using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour {

    public Vector3 g = Physics.gravity;
    Rigidbody rb;
    Collider coll;
    Vector3 pos;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDrag()
    {
        pos.x = ((Input.mousePosition.x - 1440) / 1440);
        pos.y = ((Input.mousePosition.y) / 900);
        coll.transform.position = pos;
    }
}
