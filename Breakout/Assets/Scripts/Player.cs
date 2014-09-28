using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	/// <summary>
	/// The score of the player.
	/// </summary>
	public int score;
	/// <summary>
	/// The score label.
	/// </summary>
	public GUIText scoreLabel;
	/// <summary>
	/// The lives label.
	/// </summary>
	public GUIText livesLabel;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// Update the score label
		scoreLabel.text = "Score: " + score;
	}
}
