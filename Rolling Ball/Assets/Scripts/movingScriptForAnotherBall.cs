using UnityEngine;
using System.Collections;

public class movingScriptForAnotherBall : MonoBehaviour {
	private float speed = 1.0f;

	void Update(){
		if (Input.GetKey (KeyCode.D))
			transform.position += new Vector3 (speed * Time.deltaTime, 0, 0).normalized;
		if (Input.GetKey (KeyCode.A))
			transform.position -= new Vector3 (speed * Time.deltaTime, 0, 0).normalized;
		if (Input.GetKey (KeyCode.W))
			transform.position += new Vector3 (0, 0, speed * Time.deltaTime).normalized;
		if (Input.GetKey (KeyCode.S))
			transform.position -= new Vector3 (0,0,speed * Time.deltaTime).normalized;
	}
}
