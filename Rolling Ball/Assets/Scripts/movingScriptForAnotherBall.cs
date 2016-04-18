using UnityEngine;
using System.Collections;

public class movingScriptForAnotherBall : MonoBehaviour {
	private float speed1 = 3.0f;

	void Update(){
		// adding another player through these different keys movements
		if (Input.GetKey (KeyCode.D))
			transform.position += new Vector3 (1, 0, 0).normalized * speed1 * Time.deltaTime;
		if (Input.GetKey (KeyCode.A))
			transform.position -= new Vector3 (1, 0, 0).normalized * speed1 * Time.deltaTime;
		if (Input.GetKey (KeyCode.W))
			transform.position += new Vector3 (0, 0, 1).normalized * speed1 * Time.deltaTime;
		if (Input.GetKey (KeyCode.S))
			transform.position -= new Vector3 (0,0, 1).normalized * speed1 * Time.deltaTime;

	}

}
