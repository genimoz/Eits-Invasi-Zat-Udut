using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
	GameObject player;
	PlayerHealth playerHealth;
	bool isPlayerAttacked;

	public int enemyDamage = 5;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		playerHealth = player.GetComponent<PlayerHealth>();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		// detects collision with player
		if(other.gameObject == player)
		{
			isPlayerAttacked = true;
		}
	}

	void Update()
	{
		EnemyAttacking();
	}

	public void EnemyAttacking()
	{
		if(isPlayerAttacked == true)
		{
			playerHealth.currentHealth -= enemyDamage; // damaging player
			Destroy(gameObject);
		}

	}
}
