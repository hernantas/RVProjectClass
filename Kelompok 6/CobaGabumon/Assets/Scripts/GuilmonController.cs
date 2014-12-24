using UnityEngine;
using System.Collections;

public class GuilmonController : MonoBehaviour {

	// Use this for initialization
	float walkTime;
	Animator anim;

	void Start () {
		walkTime = 0f;
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (walkTime <= 4.0f) 
		{
			transform.Translate (Vector3.forward * 1000 * Time.deltaTime);
		} 
		else if (walkTime > 4.0f && walkTime <= 4.73) 
		{
			transform.Rotate (Vector3.down * 180 * Time.deltaTime);
		}
		else if (walkTime > 15.0f && walkTime <= 15.73f) 
		{
			transform.Rotate (Vector3.down * (-90) * Time.deltaTime);
		} 
		else if (walkTime > 25.75f && walkTime <= 26.52f) 
		{
			transform.Translate (Vector3.forward * 1000 * Time.deltaTime);
		} 
		else if (walkTime > 37.0f && walkTime <= 37.73f) 
		{
			transform.Rotate (Vector3.down * (-90) * Time.deltaTime);
		} 
//		else if (walkTime > 16.0f && walkTime <= 17.0f) {
//			transform.Rotate (Vector3.down * 90 * Time.deltaTime);
//		} else if (walkTime > 17.0f && walkTime <= 27.0f) {
//			transform.Translate (Vector3.forward * 100 * Time.deltaTime);
//		} 
		
		walkTime = walkTime + Time.deltaTime;
		var currentBaseState = anim.GetCurrentAnimatorStateInfo(0);
		if (currentBaseState.nameHash == Animator.StringToHash("Base Layer.turn_right 0"))
		{
			Debug.Log(walkTime + " : walking");
		}
		Debug.Log (walkTime); 
	}
}
