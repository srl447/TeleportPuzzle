using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject player;

    bool left; //variable to move back and forth 

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
        Vector3 oldplayerPos = player.transform.position; //stores the players initial position before swapping

        if (collision.gameObject.tag == "Enemy") //swaps if telebox detects and enemy
        {
            player.transform.position = collision.gameObject.transform.position; //moves the player to the enemy position
            collision.gameObject.transform.position = oldplayerPos; //moves the enemy to the player position
        }
    }
}
