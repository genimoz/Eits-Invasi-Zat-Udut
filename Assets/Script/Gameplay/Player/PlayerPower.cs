using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerPower : MonoBehaviour
{
	public int startPower = 0;
	public int currentPower;
	public Slider powerSlider;

	void Awake()
	{
		currentPower = startPower;
	}

	void Update()
	{
		powerSlider.value = currentPower;
	}

	public void GetPower(int amount)
	{
		currentPower += amount;
		powerSlider.value = currentPower;
	}

	public void UsePowerForHealing(int amount)
	{
		currentPower -= amount;
		powerSlider.value = currentPower;
	}
}
