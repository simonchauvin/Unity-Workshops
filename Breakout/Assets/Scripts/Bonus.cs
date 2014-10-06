using UnityEngine;
using System.Collections;

public class Bonus : MonoBehaviour
{
	/// <summary>
	/// The paddle.
	/// </summary>
	private GameObject paddle;

	// Use this for initialization
	void Start ()
	{
		paddle = GameObject.Find("Paddle");
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.CompareTag("Ball"))
		{
			Debug.Log("The ball collides with a bonus");
		}
	}
}
