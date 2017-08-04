using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour {

    bool jumping, canJump;

    public float jumpSpeed;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
            canJump = false;
            StartCoroutine(JumpTime());
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            jumping = false;
        }
	}

    private void FixedUpdate()
    {
        {
            if (jumping)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpSpeed);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }

    IEnumerator JumpTime()
    {
        yield return new WaitForSecondsRealtime(.08f);
        if (jumping)
        {
            jumping = false;
        }
    }
}
