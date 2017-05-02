using UnityEngine;
using System.Collections;

public class Roller : MonoBehaviour
{
	public bool rotateClockwise = false;
	public float rollSpeed = 5f;

//	void Start()
//	{
//		GetComponent<Rigidbody2D>().angularVelocity = Random.insideUnitCircle * rollSpeed;
//	}

	void Update()
	{
		if(rotateClockwise == false)
		{
			transform.Rotate(Vector3.forward * rollSpeed);
		}
		else if(rotateClockwise == true)
		{
			transform.Rotate(Vector3.forward * -rollSpeed);
		}

	}
}
