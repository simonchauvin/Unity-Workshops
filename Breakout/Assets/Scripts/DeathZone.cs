using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour
{
	/// <summary>
	/// The player.
	/// </summary>
	private Player player;
	/// <summary>
	/// The ball prefab.
	/// </summary>
	public GameObject ballPrefab;

	// Use this for initialization
	void Start ()
	{
		// The Player
		player = GameObject.Find("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.CompareTag("Ball"))
		{
			Debug.Log("The ball enters the death zone");
		}
	}
}
