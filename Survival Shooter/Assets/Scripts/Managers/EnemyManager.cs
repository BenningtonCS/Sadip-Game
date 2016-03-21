using UnityEngine;

public class EnemyManager : MonoBehaviour
{
	public GameObject player;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

	PlayerHealth playerHealth;


    void Start ()
    {
		playerHealth = player.GetComponent<PlayerHealth> ();
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }


    void Spawn ()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
