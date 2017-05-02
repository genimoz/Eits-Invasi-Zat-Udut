using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
	public float speed = 5f;

	void Update()
	{
		transform.Translate(transform.right * -speed * Time.deltaTime);
	}
}
