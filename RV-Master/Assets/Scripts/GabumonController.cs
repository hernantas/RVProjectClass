using UnityEngine;
using System.Collections;

public class GabumonController : MonoBehaviour {
	float walkTime;
	public float scale;
	public static bool done;
	// Use this for initialization
	void Start () {
		walkTime = 0f;
		done = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		scale = 1000;

				if (walkTime <= 4.0f) {
						transform.Translate (Vector3.forward * scale * Time.deltaTime);
						//transform.Translate (new Vector3(0,0,3) * Time.deltaTime);
				} else if (walkTime > 4.0f && walkTime <= 4.5f) {
						transform.Rotate (Vector3.down * 180 * Time.deltaTime);
				} else if (walkTime > 12.5f && walkTime <= 16.0f) {
						transform.Translate (Vector3.right * scale * Time.deltaTime);
				} else if (walkTime > 16.0f && walkTime <= 17.0f) {
						transform.Rotate (Vector3.down * 90 * Time.deltaTime);
				} else if (walkTime > 17.0f && walkTime <= 27.0f) {
						if (walkTime > 19.0f) {
							done = true;
						}
						transform.Translate (Vector3.forward * scale * Time.deltaTime);
				} 

		walkTime = walkTime + Time.deltaTime;
		Debug.Log (walkTime);
	}
}
