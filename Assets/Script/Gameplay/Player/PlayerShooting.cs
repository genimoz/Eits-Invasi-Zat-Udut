using UnityEngine;
using System.Collections;
using CnControls;

public class PlayerShooting : MonoBehaviour 
{
	PlayerPower playerPower;
	public Transform weapon;
	public GameObject projectile;

	private float fireRate = 0.5f;
	private float timer;

	void Start()
	{
		playerPower = GetComponent<PlayerPower>();
		weapon = GameObject.Find("Weapon").transform;

		//Destroy(projectile);
	}

	void Update()
	{
		timer += Time.deltaTime;

//		if(Input.GetButton("Fire1") && playerPower.currentPower > 0)
//		{
//			Shooting();
//		}

		// Mobile Device Input
		if(CnInputManager.GetButtonDown("Fire") && playerPower.currentPower > 0)
		{
			Shooting();
		}

	}

	void Shooting()
	{
		if(timer > fireRate)
		{
			Instantiate(projectile, weapon.position, weapon.rotation);
			playerPower.currentPower -= 1;
			timer = 0f;
		}
	}
}
