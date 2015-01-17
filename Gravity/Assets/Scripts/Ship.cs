using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			rigidbody2D.AddForce(transform.up * 10f);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.RotateAround(transform.position, Vector3.forward, 5f);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.RotateAround(transform.position, Vector3.forward, -5f);
		}
	}
}
