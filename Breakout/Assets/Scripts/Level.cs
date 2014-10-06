using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour
{
	/// <summary>
	/// The bloc prefab.
	/// </summary>
	public GameObject blocPrefab;
	/// <summary>
	/// The paddle.
	/// </summary>
	private GameObject paddle;
	/// <summary>
	/// The ball.
	/// </summary>
	private GameObject ball;

	// Use this for initialization
	void Start ()
	{
		paddle = GameObject.Find("Paddle");
		ball = GameObject.Find("Ball");
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
}
