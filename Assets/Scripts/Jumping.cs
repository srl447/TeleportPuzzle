using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour {

    bool jumping, canJump; //checking for jump

    public float jumpSpeed; //how fast you can jump


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        //checking input for jumping
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
            canJump = false;
            StartCoroutine(JumpTime()); //starts the check for max jump time
        }
        else if (Input.GetKeyUp(KeyCode.Space)) //stops jumping when key is released
        {
            jumping = false;
        }
	}

    private void FixedUpdate()
    {
        {
            if (jumping)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpSpeed); //moves player up
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true; //rests jump when you hit anything
    }

    //stops jumping if too much time has passed
    IEnumerator JumpTime()
    {
        yield return new WaitForSecondsRealtime(.08f);
        if (jumping)
        {
            jumping = false;
        }
    }
}
