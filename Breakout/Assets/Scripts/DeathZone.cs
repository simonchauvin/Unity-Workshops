using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.CompareTag("Ball"))
		{
			Debug.Log("The ball enters the death zone");
		}
	}
}
