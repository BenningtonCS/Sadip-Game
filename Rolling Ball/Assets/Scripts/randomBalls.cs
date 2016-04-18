using UnityEngine;
using System.Collections;

public class randomBalls : MonoBehaviour {

	public Object prefab;
	private GameObject sphere;

	// Use this for initialization
	void Start () {
		// creating random number for x and z coordinates of position vector of certain game object
		float randomNumberForXZ = Random.Range (-9, 9);

		//random number position for y ccordinates of that game object
		float randomNumberForY = Random.Range (5, 8);
		Vector3 position = new Vector3 (randomNumberForXZ, randomNumberForY, randomNumberForXZ);
		sphere = (GameObject) GameObject.Instantiate (prefab, position, Quaternion.identity); 
	}

	
	// Update is called once per frame
	void Update () {
		Vector3 spherePosition = sphere.transform.position;
	}
}
