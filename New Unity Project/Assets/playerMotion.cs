using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMotion : MonoBehaviour {
    public Rigidbody rb;

    public float sidewaysForce = 500f;
    public float forwardForce = 2000f;

	// Use this for initialization
	void Start () {
	}

    /*FixedUpdate will be used when you deal witht the physics*/
    void FixedUpdate() {
        // @params AddDorce on x,y and z
        rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);

        if (Input.GetKey("up"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        //giving side way force
        if (Input.GetKey("right")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
    



}
