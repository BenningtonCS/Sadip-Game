using UnityEngine;
using System.Collections;

public class ColorChanging : MonoBehaviour {
	Color newColor;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			newColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1.0f);
			GetComponent<Renderer>().material.color = newColor;
		}
	}

}

