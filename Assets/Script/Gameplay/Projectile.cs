using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour 
{
	public float speed = 5f;

//	GameObject obstacle;
//	bool isDamaged;
//	int score;

//	void Awake()
//	{
//		obstacle = GameObject.FindGameObjectWithTag("Obstacle");
//	}
//
//	void OnTriggerEnter2D(Collider2D other)
//	{
//		if(other.gameObject == obstacle)
//		{
//			isDamaged = true;
//		}
//	}
//
//	void OnTriggerExit2D(Collider2D other)
//	{
//		if(other.gameObject == obstacle)
//		{
//			isDamaged = false;
//		}
//	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = transform.right * speed; // set movement direction of projectile

//		if(isDamaged == true)
//		{
//			Destroy(gameObject);
//			Destroy(obstacle);
//			score += 10;
//		}

		Destroy(gameObject, 5); // destroy projectile if there's nothing to get shot
	}
}
