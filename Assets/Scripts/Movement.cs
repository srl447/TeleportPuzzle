using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    bool movingLeft, movingRight;

    public static int facing; //0 is left, 1 is right

    public float speed;
	// Use this for initialization
	void Start ()
    {
        facing = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.A))
        {
            movingLeft = true;
            GetComponent<SpriteRenderer>().flipX = true;
            facing = 0;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            movingLeft = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movingRight = true;
            GetComponent<SpriteRenderer>().flipX = false;
            facing = 1;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            movingRight = false;
        }
    }

    private void FixedUpdate()
    {
        if(movingLeft)
        {
            transform.Translate(Vector3.left * speed);
        }
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed);
        }
    }
}
