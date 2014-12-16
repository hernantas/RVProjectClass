using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour {
	public float selfRotation = 1.0f;
	public float sunRotation = 1.0f;

	// Use this for initialization
	void Start () {
		// Randomized rotation
		sunRotation = Random.Range (20, 60)/1000f;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(new Vector3(0,0,selfRotation));
		this.transform.RotateAround (GameObject.Find ("Matahari").transform.position, new Vector3 (0, 1, 0), sunRotation);
	}
}
