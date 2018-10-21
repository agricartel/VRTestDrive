using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
 
        public GameObject player;       //Public variable to store a reference to the player game object


        private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame after update
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
