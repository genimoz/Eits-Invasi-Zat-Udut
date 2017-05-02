using UnityEngine;
using System.Collections;

public class CompanionMovement : MonoBehaviour 
{
	Transform player;

	PlayerMovement playerMovement;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform; // get transform component from a GameObject
		playerMovement = player.GetComponent<PlayerMovement>();
	}

	void Update()
	{
		Vector2 movement;
		//movement.Set(player.transform.x, player.transform.y);
	}
}
