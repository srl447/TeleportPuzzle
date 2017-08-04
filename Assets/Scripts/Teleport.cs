using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject player;

    bool left;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //the teleporting only works if you are moving, so constantly moving boxes slightly back and forth
        if (!left)
        {
            transform.position += Vector3.right/100;
            left = true;
        }
        else if (left)
        {
            transform.position += Vector3.left/100;
            left = false;
        }
    }
        

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 oldplayerPos = player.transform.position;
        if(collision.gameObject.tag == "Enemy")
        {
            player.transform.position = collision.gameObject.transform.position;
            collision.gameObject.transform.position = oldplayerPos;
        }
    }
}
