using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    bool movingLeft, movingRight;

    public static int facing; //0 is left, 1 is right

    public float speed; //how fast player moves

	// Use this for initialization
	void Start ()
    {
        facing = 1; //starts off facing right
	}
	
	// Update is called once per frame
	void Update ()
    {
        //inputs for moving
		if (Input.GetKey(KeyCode.A)) //move left with a
        {
            movingLeft = true;
            GetComponent<SpriteRenderer>().flipX = true; //makes sprite face left
            facing = 0; //sets variable to left
        }
        else if (Input.GetKeyUp(KeyCode.A)) //stops moving when you release a
        {
            movingLeft = false;
        }
        //A : D :: Left : Right
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
        //actually moving based on the input variables
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
