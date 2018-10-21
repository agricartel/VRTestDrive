using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour {

    //public Vector3 g = Physics.gravity;
    public Rigidbody rb;
    public Collider coll;
    Vector3 pos;
    MouseLook mousepos;
    bool jump = false;
    float jmp = 0f;

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
        pos = rb.position;
        mousepos = new MouseLook();

	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Input.GetAxis("Horizontal") + "V" + Input.GetAxis("Vertical"));
        jump = Input.GetKeyDown("joystick button 0");
        if (jump)
            jmp = 1;
        rb.AddForce(Input.GetAxis("Horizontal"),jmp, Input.GetAxis("Vertical"), ForceMode.Force);
    }

    void OnMouseDrag()
    {
        //pos.x = ((Input.mousePosition.x - 1440) / 1440);
        //pos.y = ((Input.mousePosition.y) / 900);
        //pos = mousepos.MousePos();
        //coll.transform.position = pos;
        Debug.Log(Input.GetAxis("Horizontal") + "V" + Input.GetAxis("Vertical"));
        
    }
}
