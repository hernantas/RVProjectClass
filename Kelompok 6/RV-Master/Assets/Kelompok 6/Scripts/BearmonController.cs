using UnityEngine;
using System.Collections;

public class BearmonController : MonoBehaviour {
	public float walkTime;
	public float scale;
	// Use this for initialization
	void Start () {
		walkTime = 0f;
		scale = 1000f;
	}
	
	// Update is called once per frame
	void Update () {
		if ( walkTime < 5.0f)
			transform.Translate(new Vector3(0f, 0f, 1f) * scale * Time.deltaTime);
		walkTime += Time.deltaTime;
	}
}
