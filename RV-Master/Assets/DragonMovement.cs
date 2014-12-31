using UnityEngine;
using System.Collections;

public class DragonMovement : MonoBehaviour {

	// Use this for initialization

	Animator anim;
	GameObject mark;
	int scene = 0;

	int frame = 0;
	int second = -1;
	int speed = 1000;
	int counter = 0;

	void Start () {
		anim = GetComponent<Animator> ();

		mark = GameObject.Find ("Mark1");

		anim.SetBool ("isMoving", true); //walk
		}
	
	// Update is called once per frame
	void Update () {
		if(anim.GetBool("isMoving")) 
			transform.position = Vector3.MoveTowards (transform.position, mark.transform.position, speed * Time.deltaTime);

		if (transform.position == mark.transform.position) {
			if(scene == 0){
				anim.SetBool ("isMoving", false);
				anim.SetTrigger ("goFire 0"); //breath fire
				counter++;
				if(counter==180){
					counter = 0;
					scene++;
					anim.ResetTrigger ("goFire 0");
				}
			}
			else if(scene == 1) {
				anim.SetBool ("goFly", true);
				anim.SetBool ("isMoving", true);
				mark = GameObject.Find ("Mark2"); //fly fast to mark2
				scene++;
			}
			else if(scene == 2) {
				anim.SetTrigger ("goFire 0");
				anim.SetBool ("goFly", false); //fly
				anim.SetBool ("onGround", false);
				mark = GameObject.Find ("Mark3"); //fly to mark3
				scene++;
			}
			else if(scene == 3) {
				anim.SetTrigger ("goAttack 0");
				mark = GameObject.Find ("Mark2"); //fly attack
				scene++;
			}
			else if(scene == 4) {
				mark = GameObject.Find ("Mark4"); //fly to mark4
				counter++;
				if(counter==180){
					counter = 0;
					anim.SetTrigger ("goFire 0");//fire from mark4
					scene++;
					//anim.ResetTrigger ("goFire 0"); 
				}
			}
			else if(scene == 5) {
				mark = GameObject.Find ("Mark3"); //fly to mark3
				scene++;
			}
			else if(scene == 6) {
				anim.SetTrigger ("goAttack 0"); //attack on mark3
				scene++;
			}
			else if(scene == 7) {
				mark = GameObject.Find ("Mark3a"); //fly to mark3a
				scene++;
			}
			else if(scene == 8) {
				anim.SetTrigger ("goAttack 0"); //attack2 on mark3a
				scene++;
			}
			else if(scene == 9) {
				mark = GameObject.Find ("Mark3b"); //fly to mark3b
				scene++;
			}
			else if(scene == 10) {
				anim.SetTrigger ("goAttack 0"); //attack2 on mark3b
				scene++;
			}
			else if(scene == 11) {
				mark = GameObject.Find ("Mark3"); //fly to mark3
				scene++;
			}
			else if(scene == 12) {
				mark = GameObject.Find ("Mark5"); //fly to mark5
				scene++;
			}
			else if(scene == 13) {
				speed = 5000;
				mark = GameObject.Find ("Mark4"); //fly to mark4
				scene++;
			}
			else if(scene == 14) {
				anim.SetTrigger ("goFire 0"); //fly to mark3
				mark = GameObject.Find ("Mark3");
				scene++;
			}
			else if(scene == 15) {
				anim.SetTrigger ("goAttack 0"); //attack on mark3
				scene++;
			}
			else if(scene == 16) {
				counter++;
				if(counter==180){
					counter = 0;
					speed = 2500;
					mark = GameObject.Find ("Mark6"); //fly exit to mark6
					scene++;
				}
			}
		}
	}
}
