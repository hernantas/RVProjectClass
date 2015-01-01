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
		//if(done == true) 
		//{
			if (walkTime <= 1.0f) {
				transform.Translate (new Vector3(0, 0, 1) * scale  * Time.deltaTime);
			} 
			walkTime = walkTime + Time.deltaTime;
			Debug.Log (walkTime);
		//}
	}
}
