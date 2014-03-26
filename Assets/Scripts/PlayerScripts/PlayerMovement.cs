using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

		int MovementSpeed;


		// Use this for initialization
		void Start ()
		{
				MovementSpeed = 1;
		}
	
		// Update is called once per frame
		void Update ()
		{

				float HorizontalMovement = Input.GetAxis ("Horizontal");
				float VerticalMovement = Input.GetAxis ("Vertical");

				Vector3 MovementDirection = new Vector2 (HorizontalMovement, VerticalMovement);

				rigidbody2D.velocity (MovementDirection);
		}
}
