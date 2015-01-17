using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour
{
	private Transform ship;

	// Use this for initialization
	void Start ()
	{
		ship = GameObject.Find("Ship").transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
		float masses = rigidbody2D.mass * ship.rigidbody2D.mass;
		float g = 6.67f;
		Vector3 distance = ship.position - transform.position;
		ship.rigidbody2D.AddForce(-g * (masses / (distance.magnitude * distance.magnitude)) * distance.normalized);
	}
}
