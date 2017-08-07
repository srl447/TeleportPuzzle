using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitboxes : MonoBehaviour {

    public float hPower, vPower;

    bool left;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //the hitting only works if you are moving, so constantly moving boxes slightly back and forth
        if (!left)
        {
            transform.position += Vector3.right / 100;
            left = true;
        }
        else if (left)
        {
            transform.position += Vector3.left / 100;
            left = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (Movement.facing == 0)
            {
                collision.GetComponent<Rigidbody2D>().AddForce(new Vector3(-1f * hPower, 1f* vPower, 0f));
            }
            else
            {
                collision.GetComponent<Rigidbody2D>().AddForce(new Vector3(1f * hPower, 1f * vPower, 0f));
            }
        }
    }
}
