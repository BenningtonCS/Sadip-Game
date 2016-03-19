using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class movingScript : MonoBehaviour {

	Rigidbody physicsBody;
 	float speed = 10f;
	public Text countText;
	public int count;
	public GameObject prefab;
	GameObject fire;
	//public AudioClip audioClip;

	AudioSource playerAudio;

	// Use this for initialization
	void Start () {
		physicsBody = GetComponent<Rigidbody> ();
		playerAudio = GetComponent<AudioSource> ();
		count = 0;
		SetCountText ();
	}


	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxisRaw ("Horizontal");
		float verticalInput = Input.GetAxisRaw ("Vertical");
		Vector3 movementVector = new Vector3 (horizontalInput, 0, verticalInput);
		physicsBody.AddForce (movementVector.normalized * speed);

		if (fire) {
			fire.transform.position = transform.position;
		}


		Vector3 ballPosition = physicsBody.position;
		if(ballPosition.y < 0){ //since ground is a plane so we can check Y-coordinate of plane for knowing whether the ball is in the ground or not.
			Debug.Log("Game Over!!");
			Debug.Log ("Game Over GoodBye!!");
		}


	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count += 1;
				SetCountText();
			// ball will be scaled everytime it gets some points
			transform.localScale += new Vector3 (.09f,.09f,.09f); 
			// speed of the ball will be decreased everytime it gains some points
			speed -= 0.02f;
			playerAudio.Play();
		}


		if(other.gameObject.CompareTag("Particle System")){ // ball follows fire everytime it goes in  fire.
			fire = GameObject.Instantiate (prefab);
		}
	}


	void SetCountText(){
		countText.text = "Count: " + count.ToString ();
		if (count == 40) {
			Debug.Log ("You Won! Can you through another ball out of the arena?");
		} else {
			Debug.Log ("There are " + (40 - count) + " pick ups remaining!");
		}
	}
}
