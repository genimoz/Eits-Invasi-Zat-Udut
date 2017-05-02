using UnityEngine;
using System.Collections;

public class ParallaxScroller : MonoBehaviour 
{
	public Transform[] backgrounds;
	public float[] backgroundsSpeed;

	Vector2 startPosition;

	void Awake()
	{
		//backgrounds = GetComponent<Transform>().gameObject;
		backgrounds = GetComponents<Transform>();
	}

	void Update()
	{
		for(int i = 0; i < backgrounds.Length; i++)
		{
			Vector2 movement = new Vector2(backgroundsSpeed[i], 0f);
			movement *= Time.deltaTime;
			backgrounds[i].Translate(-movement);
			//targetsSprite[i].position = Vector2.left * targetsSpeed[i];
		}
	}

	void Setup()
	{
//		for(int i = 0; i <targetsSprite.Length; i++)
//		{
//			targetsSprite[i].position = startPosition + (Vector2.left * targetsSpeed[i]);
//		}
	}
}
