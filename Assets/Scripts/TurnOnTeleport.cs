using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTeleport : MonoBehaviour {

    public GameObject teleBox1, teleBox2; // two teleport boxes on either side
    public GameObject hitbox1, hitbox2; // two hitboxes on either side

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //activates either box depending on which way the player is facing
		if(Input.GetKeyDown(KeyCode.E))
        {
            if (Movement.facing == 1)
            {
                teleBox1.SetActive(true);
                hitbox1.SetActive(true);
            }
            else if (Movement.facing == 0)
            {
                teleBox2.SetActive(true);
                hitbox2.SetActive(true);
            }
            StartCoroutine(TeleportBox());
        }
	}

    //Teleport box active for 3 frames before turing off
    IEnumerator TeleportBox()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        teleBox1.SetActive(false);
        teleBox2.SetActive(false);
        hitbox1.SetActive(false);
        hitbox2.SetActive(false);
    }
}
