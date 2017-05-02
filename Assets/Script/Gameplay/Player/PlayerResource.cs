using UnityEngine;
using System.Collections;

public class PlayerResource : MonoBehaviour 
{
	GameObject player;
	PlayerPower playerPower;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		playerPower = player.GetComponent<PlayerPower>();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			playerPower.currentPower += 10;
			Destroy(gameObject);
		}
	}

	void Update()
	{
		Destroy(gameObject, 6);
	}
}
