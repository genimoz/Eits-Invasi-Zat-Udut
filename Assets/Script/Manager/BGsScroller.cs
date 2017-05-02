using UnityEngine;
using System.Collections;

public class BGsScroller : MonoBehaviour 
{
	public float scrollSpeed;
	public float bgSize;
	Vector3 startPosition;
	RectTransform rect;
	Canvas canvas;

	void Start()
	{
		canvas = GetComponentInParent<Canvas>();
		rect = canvas.GetComponentInParent<RectTransform>();
		startPosition = transform.position;
		bgSize = rect.rect.width;
	}

	void Update()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, bgSize);
		transform.position = startPosition + Vector3.left * newPosition;
	}
}
