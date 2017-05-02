using UnityEngine;
using System.Collections;
using CnControls;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class PlayerMovement : MonoBehaviour 
{
	public Boundary boundary;
	public Transform player;
	public float moveSpeed = 10f;

	Vector2 movement;
	Rigidbody2D playerRigidbody;
	SpriteRenderer sprite;

	void Awake()
	{
		playerRigidbody = GetComponent<Rigidbody2D>();
		sprite = GetComponentInChildren<SpriteRenderer>();
	}

	void FixedUpdate()
	{
//		float h = Input.GetAxisRaw("Horizontal");
//		float v = Input.GetAxisRaw("Vertical");

		// Mobile Device Input
		float h = CnInputManager.GetAxisRaw("Horizontal");
		float v = CnInputManager.GetAxisRaw("Vertical");

		Moving(h, v);
	}

	void Moving(float h, float v)
	{
//		-- used in vector3 --
//		movement.Set(h, v, 0); // set movement direction
//		movement = movement.normalized * moveSpeed * Time.deltaTime; // apply speed to movement
//
//		playerRigidbody.MovePosition(player.position + movement); // move the player

		movement = new Vector2(h, v);
		playerRigidbody.velocity = movement * moveSpeed;

		playerRigidbody.position = new Vector2
			(
				Mathf.Clamp(playerRigidbody.position.x, boundary.xMin, boundary.xMax),
				Mathf.Clamp(playerRigidbody.position.y, boundary.yMin, boundary.yMax)
			);


		if(movement.x < 0)
		{
			sprite.flipX = true;
		}
		else
		{
			sprite.flipX = false;
		}
	}

}
