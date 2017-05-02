using UnityEngine;
using System.Collections;

public class CameraSlide : MonoBehaviour 
{
	public float scrollSpeed = 0.1f;
	public Transform targetTransform;

	private Vector3 targetPosition;
	private Rigidbody cameraRigidbody;

	void Start()
	{
		targetTransform = GetComponent<Transform>();
		targetPosition = targetTransform.position;

		cameraRigidbody = GetComponent<Rigidbody>();
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.S))
		{
			Panning();
		}
		if(Input.GetKey(KeyCode.H))
		{
			
		}
			
//		transform.position = target.transform.position + newPosition;
//
//		if(transform.position.x >= newPosition.x)
//		{
//			scrollSpeed = 0f;
//		}
	}

	void Panning()
	{
		//transform.Translate(newPosition * scrollSpeed);


		cameraRigidbody.MovePosition(targetPosition);
	}
}
