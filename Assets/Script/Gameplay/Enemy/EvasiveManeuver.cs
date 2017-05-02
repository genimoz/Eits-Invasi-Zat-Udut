using UnityEngine;
using System.Collections;

public class EvasiveManeuver : MonoBehaviour 
{
	public Boundary boundary;
	public float dodge;
	public float smoothing;
	public Vector2 startWait;
	public Vector2 maneuverTime;
	public Vector2 maneuverWait;

	private float currentSpeed;
	private float targetManuever;

	IEnumerator Evade()
	{
		yield return new WaitForSeconds(Random.Range(startWait.x, startWait.y));

		while(true)
		{
			targetManuever = Random.Range(dodge, 1) * Mathf.Sign(transform.position.y);
			yield return new WaitForSeconds(Random.Range(maneuverTime.x, maneuverTime.y));
			targetManuever = 0;
			yield return new WaitForSeconds(Random.Range(maneuverTime.x, maneuverTime.y));
		}
	}

	void FixedUpdate()
	{
		float newManeuver = Mathf.MoveTowards(GetComponent<Rigidbody2D>().velocity.x, targetManuever, smoothing);
		GetComponent<Rigidbody2D>().velocity = new Vector2(currentSpeed, newManeuver);
		GetComponent<Rigidbody2D>().position = new Vector2
			(
				Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, boundary.xMin, boundary.xMax),
				Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, boundary.yMin, boundary.yMax)
			);
	}
}
