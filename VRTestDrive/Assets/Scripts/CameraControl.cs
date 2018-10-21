using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject player;       //Public variable to store a reference to the player game object

    public Rigidbody playerBody;    //Public variable to store a reference to the player's Rigidbody

    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
        playerBody = player.GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
    }

    // LateUpdate is called once per frame after update
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    void MovePlayer()
    {
        //playerBody.AddForce(Input.GetAxis("Horizontal2"),0f,Input.GetAxis("Vertical2"),ForceMode.Force);
    }
}
