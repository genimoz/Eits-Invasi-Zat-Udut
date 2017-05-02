using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour 
{
	public float scrollSpeed;
	public float backgroundSize;

	private Vector3 startPosition;

	void Start()
	{
		startPosition = transform.position;
	}

	void Update()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, backgroundSize);
		transform.position = startPosition + Vector3.left * newPosition;
	}
}
