using UnityEngine;
using System.Collections;

public class randomBalls : MonoBehaviour {

	public Object prefab;
	private GameObject sphere;

	// Use this for initialization
	void Start () {
		float randomNumberForXZ = Random.Range (-9, 9);
		float randomNumberForY = Random.Range (5, 8);
		Vector3 position = new Vector3 (randomNumberForXZ, randomNumberForY, randomNumberForXZ);
		sphere = (GameObject) GameObject.Instantiate (prefab, position, Quaternion.identity); 
	}

	
	// Update is called once per frame
	void Update () {
		Vector3 spherePosition = sphere.transform.position;
	}
}
