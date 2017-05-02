using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour 
{
	public GameObject player;
	public float restartDelay = 3f;

	private PlayerHealth playerHealth;
	private SpriteRenderer playerRenderer;

	float restartTimer = 0f;

	void Awake()
	{
		playerHealth = player.GetComponent<PlayerHealth>();
		playerRenderer = player.GetComponentInChildren<SpriteRenderer>();
	}

	void Update()
	{
		if(playerHealth.currentHealth <= 0)
		{
			// player enter ghost mode when dead
			Color faded = playerRenderer.material.color;
			faded.a -= 0.5f * Time.deltaTime;
			playerRenderer.material.color = faded;

			restartTimer += Time.deltaTime;
		}

		if(restartTimer >= restartDelay)
		{
			SceneManager.LoadScene("Gameplay");
		}
	}
}
