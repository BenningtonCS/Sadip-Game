using UnityEngine;
using System.Collections;

public class movingScript : MonoBehaviour {

	Rigidbody physicsBody;
 	float speed = 10f;

	// Use this for initialization
	void Start () {
		physicsBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxisRaw ("Horizontal");
		float verticalInput = Input.GetAxisRaw ("Vertical");
		Vector3 movementVector = new Vector3 (horizontalInput, 0, verticalInput); //Vector3(1, 0, 1)
		physicsBody.AddForce (movementVector.normalized * speed);
	}

}
