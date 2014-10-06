﻿using UnityEngine;
using System.Collections;

public class Malus : MonoBehaviour
{
	/// <summary>
	/// The ball.
	/// </summary>
	private GameObject ball;

	// Use this for initialization
	void Start ()
	{
		ball = GameObject.Find("Ball");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.CompareTag("Ball"))
		{
			Debug.Log("The ball collides with a malus");
		}
	}
}
