using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	/// <summary>
	/// The speed at which the paddle moves.
	/// </summary>
	public float speed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
	}
}
