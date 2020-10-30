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


    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    // void Update () {
    void FixedUpdate ()
    { //FixedUpdate for updating physics

        //w/o Time.deltaTime, constantly apply
        //with Time.deltaTime, apply once per frame or specific situation

        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a force of 2000 on z-axis

        if (Input.GetKey("d")) //right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //VelocityChange ignore its mass
        }
        if (Input.GetKey("a")) //left
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //VelocityChange ignore its mass
        }
    
        if(rb.position.y < -1f) //if falls
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
