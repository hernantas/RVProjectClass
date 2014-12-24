using UnityEngine;
using System.Collections;

public class GuilmonController : MonoBehaviour {

	// Use this for initialization
	float walkTime;
	void Start () {
		walkTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (walkTime <= 4.0f) {
			transform.Translate (Vector3.forward * 100 * Time.deltaTime);
		} else if (walkTime > 4.0f && walkTime <= 7.48f) {
			transform.Rotate (Vector3.down * 180 * Time.deltaTime);
		} else if (walkTime > 7.48f && walkTime <= 16.0f) {
			transform.Translate (Vector3.right * 100 * Time.deltaTime);
		} else if (walkTime > 16.0f && walkTime <= 17.0f) {
			transform.Rotate (Vector3.down * 90 * Time.deltaTime);
		} else if (walkTime > 17.0f && walkTime <= 27.0f) {
			transform.Translate (Vector3.forward * 100 * Time.deltaTime);
		} 
		
		walkTime = walkTime + Time.deltaTime;
		Debug.Log (walkTime);
	}
}
