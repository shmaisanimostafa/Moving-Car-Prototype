using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private readonly float speed = 10.0f;
	private readonly float turnSpeed = 40f;
	private float verticalInput;
	private float horizontalInput;

	public new GameObject camera;
	private bool move = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");

		// For starting animation
		if (camera.transform.position.z <= -8)
        {
            move = true;
        }

		// We'll move the vehicle forward
		if (move)
        {
			transform.Translate(speed * verticalInput * Time.deltaTime * Vector3.forward);
            // transform.Translate(turnSpeed * horizontalInput * Time.deltaTime * Vector3.right);
            transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
		}
        
    }
}
