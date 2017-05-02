using UnityEngine;
using System.Collections;

public class DrawLine : MonoBehaviour 
{
	LineRenderer line;
	float distance;
	float counter;

	public Transform origin;
	public Transform destination;
	public float lineDrawSpeed = 5f;

	void Start()
	{
		line = GetComponent<LineRenderer>();
		line.SetPosition(0, origin.position);
		line.SetWidth(0.5f, 0.5f);

		distance = Vector3.Distance(origin.position, destination.position);
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.F))
		{
			Draw();
		}
		else if(Input.GetKey(KeyCode.R))
		{
			Destroy(line);
		}
	}

	void Draw()
	{
		counter += 0.1f / lineDrawSpeed;

		float x = Mathf.Lerp(0, distance, counter);

		Vector3 pointA = origin.position;
		Vector3 pointB = destination.position;

		Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;

		line.SetPosition(1, pointAlongLine);
	}
}
