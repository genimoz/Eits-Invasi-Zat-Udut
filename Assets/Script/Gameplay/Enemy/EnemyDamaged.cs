using UnityEngine;
using System.Collections;

public class EnemyDamaged : MonoBehaviour 
{
	public int scoreValue = 10;
	public GameObject shootEffect;

	GameObject projectile;
	int score;
	bool isDamaged = false;

	void Start()
	{
		projectile = GameObject.FindGameObjectWithTag("Projectile");
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Projectile" || other.gameObject == projectile)
		{
			isDamaged = true;

			ScoreManager.score += scoreValue;
			Destroy(gameObject);
			Destroy(other.gameObject);
		}
		else 
		{
			isDamaged = false;
		}
	}

//	void OnTriggerExit2D(Collider2D other)
//	{
//		if(other.gameObject == projectile)
//		{
//			isDamaged = false;
//		}
//	}

	void Update()
	{
		if(isDamaged = true)
		{
			GameObject shootInstance = (GameObject)Instantiate(shootEffect, transform.position, transform.rotation);
			Destroy(shootInstance, 3f);
		}
		
		//TakeDamage();
		Destroy(gameObject, 6);
		Debug.Log(score);
	}

//	public void TakeDamage()
//	{
//		if(isDamaged == true)
//		{
//			ScoreManager.score += scoreValue;
//			Destroy(gameObject);
//			isDamaged = false;
//		}
//	}
}
