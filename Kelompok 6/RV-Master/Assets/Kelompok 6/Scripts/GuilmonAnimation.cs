using UnityEngine;
using System.Collections;

public class GuilmonAnimation : MonoBehaviour {
	public int scale = 1000;
	private float walkTime;
	// Use this for initialization
	void Start () {
		walkTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if ( walkTime < 5.0f)
			transform.Translate(new Vector3(0f, 0f, 0.3f) * scale * Time.deltaTime);
		walkTime += Time.deltaTime;
	}
}
