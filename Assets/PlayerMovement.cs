//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;


	// Use this for initialization
	void Start ()
    { // run when your game starts

        //Debug.Log("Hello, World!");

        //rb.useGravity = false;
        //rb.AddForce(0, 200, 500);
    }
	
	// Update is called once per frame
	//void Update () {
	void FixedUpdate () { //FixedUpdate for updating physics
        rb.AddForce(0, 0, 2000 * Time.deltaTime); //add a force of 2000 on z-axis
    }
}
