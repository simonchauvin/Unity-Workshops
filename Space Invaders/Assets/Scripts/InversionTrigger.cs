using UnityEngine;
using System.Collections;

public class InversionTrigger : MonoBehaviour
{
	/// <summary>
	/// The invaders manager.
	/// </summary>
	private InvadersManager invadersManager;

	// Use this for initialization
	void Start ()
	{
		invadersManager = GameObject.Find("Invaders").GetComponent<InvadersManager>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.CompareTag("Invader"))
		{

		}
	}
}
