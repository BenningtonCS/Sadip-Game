using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {

	// this is for changing camera position according to the game object position
	// here camera follows the sphere ball without rotating

	public GameObject player;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		// to find the offset we need to find the position vector of player object and camera position through vector difference.
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
