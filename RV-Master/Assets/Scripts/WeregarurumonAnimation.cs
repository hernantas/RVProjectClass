using UnityEngine;
using System.Collections;

public class WeregarurumonAnimation : MonoBehaviour {
	public float walkTime;
	public float scale;
	public bool done;
	// Use this for initialization
	void Start () {
		walkTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		done = GabumonController.done;
        scale = 1000;
		if(done == true) 
		{
			if (walkTime <= 4.0f) {
				transform.Translate (new Vector3(0, 0, 1) * scale  * Time.deltaTime);
			} 
			else if (walkTime > 4.0f && walkTime <= 4.5f) {
				transform.Rotate (Vector3.down * 180 * Time.deltaTime);
			} 
			else if (walkTime > 12.5f && walkTime <= 16.0f) 
			{
				transform.Translate (Vector3.right * Time.deltaTime);
			} 
			else if (walkTime > 16.0f && walkTime <= 17.0f) {
			//			transform.Rotate (Vector3.down * 90 * Time.deltaTime);
			//		} else if (walkTime > 17.0f && walkTime <= 27.0f) {
			//			transform.Translate (Vector3.forward * Time.deltaTime);
			//		} 
			}
			walkTime = walkTime + Time.deltaTime;
			Debug.Log (walkTime);
		}
	}
}
