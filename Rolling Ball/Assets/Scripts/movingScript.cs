using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class movingScript : MonoBehaviour {

	Rigidbody physicsBody;
 	float speed = 10f;
	public Text countText;
	//public Text winText;
	private int count;

	// Use this for initialization
	void Start () {
		physicsBody = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		//winText = "";
	}
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxisRaw ("Horizontal");
		float verticalInput = Input.GetAxisRaw ("Vertical");
		Vector3 movementVector = new Vector3 (horizontalInput, 0, verticalInput); //Vector3(1, 0, 1)
		physicsBody.AddForce (movementVector.normalized * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count += 1;
				SetCountText();
		}
	}

	void SetCountText(){
		countText.text = "Count: " + count.ToString ();
		/*if(count >= 8){
			winText = "You Win!";
		}*/
	}
}
