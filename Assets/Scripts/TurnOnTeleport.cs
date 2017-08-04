using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTeleport : MonoBehaviour {

    public GameObject teleBox1, teleBox2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.E))
        {
            if (Movement.facing == 1)
            {
                teleBox1.SetActive(true);
            }
            else if (Movement.facing == 0)
            {
                teleBox2.SetActive(true);
            }
            StartCoroutine(TeleportBox());
        }
	}

    IEnumerator TeleportBox()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        teleBox1.SetActive(false);
        teleBox2.SetActive(false);
    }
}
