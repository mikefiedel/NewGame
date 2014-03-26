using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

	int MovementSpeed;


	// Use this for initialization
	void Start ()
	{
		MovementSpeed = 20;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void FixedUpdate ()
	{
		float HorizontalMovement = Input.GetAxis ("Horizontal");
		float VerticalMovement = Input.GetAxis ("Vertical");

		Vector2 MovementDirection = new Vector2 (HorizontalMovement * MovementSpeed, VerticalMovement * MovementSpeed);
		rigidbody2D.velocity = MovementDirection;
	}

}
