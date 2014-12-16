using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour {
	public float earthHourPerDay = 24.0f;
	public float earthHousePerYear = 8760.0f;
	private GameObject centerObject;

	// Use this for initialization
	void Start () {
		// Randomized rotation
		//sunRotation = Random.Range (20, 60)/100f;
		centerObject = GameObject.Find ("Matahari");
		this.transform.RotateAround (centerObject.transform.position, new Vector3 (0, 1, 0), Random.Range(0,360));
		//sunRotation = Random.Range(240,720);
	}
	
	// Update is called once per frame
	void Update () {
		// selftRotation 24 = 1 day for earth = 100s simulation
		// 24/24 * 1/360;
		// inc: 360
		float timescale = 10;
		this.transform.Rotate(new Vector3(0,0,24/earthHourPerDay)*360/timescale*Time.deltaTime);
		//Debug.Log ((sunRotation / 365));
		this.transform.RotateAround (centerObject.transform.position, new Vector3 (0, 1, 0), (24/earthHousePerYear)*360/timescale*Time.deltaTime);
	}
}
