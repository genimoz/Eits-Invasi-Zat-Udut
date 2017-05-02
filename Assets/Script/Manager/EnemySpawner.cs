using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour 
{
	public GameObject[] obstacles;
	public float minSpawnPoint = 1f;
	public float maxSpawnPoint = 2f;

	void Start()
	{
		Spawn();
	}

	void Spawn()
	{
		Instantiate (obstacles [Random.Range (0, obstacles.GetLength(0))], transform.position, Quaternion.identity);
		Invoke ("Spawn", Random.Range (minSpawnPoint, maxSpawnPoint));
	}
}
