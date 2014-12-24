using UnityEngine;
using System.Collections;

public class GabumonController : MonoBehaviour {
	float walkTime;
	// Use this for initialization
	void Start () {
		walkTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
				// translate itu jalan
				if (walkTime <= 4.0f) {
						transform.Translate (Vector3.forward * 1000 * Time.deltaTime);
				} 
				// rotate itu belok belok
				else if (walkTime > 4.0f && walkTime <= 4.5f) {
						transform.Rotate (Vector3.down * 180 * Time.deltaTime);
				}
				
				else if (walkTime > 12.5f && walkTime <= 16.0f) {
						transform.Translate (Vector3.right * 1000 * Time.deltaTime);
				} else if (walkTime > 16.0f && walkTime <= 17.0f) {
						transform.Rotate (Vector3.down * 90 * Time.deltaTime);
				} else if (walkTime > 17.0f && walkTime <= 27.0f) {
						transform.Translate (Vector3.forward * 1000	 * Time.deltaTime);
				} 

		walkTime = walkTime + Time.deltaTime;
		Debug.Log (walkTime);
	}
}
