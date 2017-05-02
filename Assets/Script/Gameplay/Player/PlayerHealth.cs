using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public int startHealth = 100;
	public int currentHealth;
	public Slider healthSlider;

	public Button healingButton;

	PlayerPower playerPower;

	void Awake()
	{
		currentHealth = startHealth;
	}

	void Update()
	{
		// make sure the player cannot have health more than 100
		if(currentHealth > 100)
		{
			currentHealth = 100;
		}

		healthSlider.value = currentHealth;
	}

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		healthSlider.value = currentHealth;
	}

	public void Healing(int amount)
	{
		if(playerPower.currentPower == 50)
		{
			currentHealth += amount;
		}	

		healthSlider.value = currentHealth;
	}
}
