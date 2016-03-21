using UnityEngine;

public class GameOverManager : MonoBehaviour
{
	public GameObject player;
	public float restartDelay = 5f;

    Animator anim;
	float restartTimer;

	private PlayerHealth playerHealth;

    void Awake()
    {
		playerHealth = player.GetComponent<PlayerHealth> ();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
			Debug.Log ("game over");
            anim.SetTrigger("GameOver");

			restartTimer += Time.deltaTime;

			if(restartTimer >= restartDelay){
				Application.LoadLevel (Application.loadedLevel);
			}
        }
    }
}
