using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public GameObject player;
	private bool move1 = true;
	private bool move2 = false;
	private bool move3 = false;

    private Vector3 offset = new(0, 6, -8);

	// Start is called before the first frame update
	void Start()
    {
        
    }

	// Update is called once per frame
	void LateUpdate()
    {
		// For starting animation
        if(move1) { transform.position += new Vector3(0, (float)0.5 * Time.deltaTime * 7, 0); }
		
		if (transform.position.y >= 6){move1 = false; move2 = true; }

        if (move2) { transform.position -= new Vector3(0, 0, 1*Time.deltaTime * 5); }

		if (transform.position.z <= -8) { move2 = false; move3 = true; }

		// Follow the player
		if (move3)
		{
            transform.position = player.transform.position + offset;
		}
		
    }
}
