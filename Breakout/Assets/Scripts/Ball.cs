using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {



	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (-5, 1, 0);
		rigidbody2D.AddForce (new Vector2(5, -5), ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.collider.CompareTag("Block"))
		{
			Debug.Log("The ball collides with a block");

			// Destroy the block
			Destroy(collision.collider.gameObject);
		}
	}
}
