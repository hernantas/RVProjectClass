using UnityEngine;
using System.Collections;

public class knight2behavior : MonoBehaviour {

	public Transform target;
	public Transform lookat;
	
	
	public float speed;
	int walkHash = Animator.StringToHash("Base Layer.walk");
	int heavy_atkHash = Animator.StringToHash("Base Layer.heavy attack");
	int stunnedHash = Animator.StringToHash ("Base Layer.stunned");
	int stanceHash = Animator.StringToHash ("Base Layer.stance");
	int tauntHash = Animator.StringToHash ("Base Layer.taunt");
	int heavy_attk_trigger = Animator.StringToHash ("heavy_attk");
	int stance_trigger = Animator.StringToHash ("stance");
	string scene;
	public GameObject knight2_mesh;
	public GameObject knight1;
	public Animator anim;
	int counter = 0;

	Transform pivot_jump_attack;
	Transform pivot_exit;
	Transform pivot_last_avoid;
	Transform pivot_last_attack;

	public float RotationSpeed;
	private Quaternion _lookRotation;
	private Vector3 _direction;

	// Use this for initialization
	void Start () {
		scene = "scene1";
		knight1 = GameObject.Find ("ksatria1");
		anim = GetComponent<Animator>();
		//target =GameObject.Find ("pivot1walkentrybad").transform;
		lookat =GameObject.Find("ImageTarget").transform;
		knight2_mesh= GameObject.Find ("knight2_mesh");
		knight2_mesh.renderer.enabled = false;
		pivot_jump_attack = GameObject.Find ("pivotJumpAttack").transform;
		pivot_last_avoid = GameObject.Find ("pivotLastAvoid").transform;
		pivot_last_attack = GameObject.Find ("pivotLastAttack").transform;
		pivot_exit = GameObject.Find ("exitPivot").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (scene == "scene1") {
			counter++;
			if(counter == 1000)
			{
				knight2_mesh.renderer.enabled=true;
				scene = "scene2";
				counter = 0;
			}
		}

		if (scene == "scene2") 
		{
			anim.SetBool("fallentry",true);
			counter++;
			if(counter == 100)
			{
				counter =0;
				scene = "scene3";
			}
		}

		if (scene == "scene3") 
		{
			anim.SetBool("fallentry",false);
			counter++;
			if(counter == 400)
			{
				anim.SetBool("declare",true);
				counter = 0;
				scene = "scene4";
			}
		}

		if (scene == "scene4") 
		{
					_direction = (knight1.transform.position - transform.position).normalized;
					_lookRotation = Quaternion.LookRotation (_direction);
					transform.rotation = Quaternion.Slerp (transform.rotation, _lookRotation, Time.deltaTime * 100);
					counter++;
					if (counter > 100) {
							anim.SetBool ("declare", false);
							anim.SetBool ("jump_attack", true);
							_direction = (knight1.transform.position - transform.position).normalized;
							_lookRotation = Quaternion.LookRotation (_direction);
							transform.rotation = Quaternion.Slerp (transform.rotation, _lookRotation, Time.deltaTime * 100);
							float step = 3700 * Time.deltaTime;
							transform.position = Vector3.MoveTowards (transform.position, pivot_jump_attack.position, step);
							if (transform.position == pivot_jump_attack.transform.position) {
									scene = "scene5";
									counter = 0;
									anim.SetBool ("jump_attack", false);
							}
					}
		}
		if (scene == "scene5") 
		{
			counter++;
			if(counter == 40)
			{
				anim.SetBool("react _right",true);
			}
			if(counter == 70)
				anim.SetBool("react _right",false);
			if(counter == 100)
			{
				anim.SetBool("atk_small_left",true);
			}
			if(counter == 130)
				anim.SetBool("atk_small_left",false);
			if(counter == 170)
			{
				anim.SetBool("react _right",true);
			}
			if(counter == 200)
				anim.SetBool("react _right",false);
			if(counter == 230)
			{
				anim.SetBool("atk_small_left",true);
			}
			if(counter == 260)
				anim.SetBool("atk_small_left",false);
			if(counter == 260)
			{
				anim.SetBool("jump_attack",true);
			}
			if(counter == 290)
			{
				anim.SetBool("jump_attack",false);
				anim.SetBool("pedang_mental",true);
			}
			if(counter == 330)
			{
				anim.SetBool("pedang_mental",false);
			}
			if(counter == 380)
			{
				anim.SetBool("tebas_up",true);
			}
			if(counter == 410)
			{
				anim.SetBool("tebas_up",false);
			}
			if(counter == 430)
			{
				anim.SetBool("blok",true);
			}
			if(counter == 455)
			{
				anim.SetBool("blok",false);
			}
			if(counter == 475)
			{
				anim.SetBool("tebas_down",true);
			}
			if(counter == 505)
			{
				anim.SetBool ("tebas_down",false);
			}

			if(counter ==  525)
			{
				anim.SetBool("tebas_up",true);
			}
			if(counter ==  545)
			{
				anim.SetBool("tebas_up",false);
			}
			if(counter ==  565)
			{
				anim.SetBool("blok",true);
			}
			if(counter ==  590 )
			{
				anim.SetBool("blok",false);
			}
			if(counter ==  610)
			{
				anim.SetBool("tebas_down",true);
			}
			if(counter ==  640)
			{
				anim.SetBool ("tebas_down",false);
				counter =0;
				scene = "scene6";
			}
		}

		if(scene =="scene6")
		{
			counter++;
			if(counter>40)
			{
				anim.SetBool("evade",true);
				float step = 3700 * Time.deltaTime;
				transform.position = Vector3.MoveTowards(transform.position, pivot_last_avoid.position, step);
				if (transform.position == pivot_last_avoid.position) 
				{
					counter = 0;
					anim.SetBool ("evade", false);
					scene = "scene7";
				}
			}
		}

		if(scene == "scene7")
		{
			counter++;
			if(counter > 50)
			{
				anim.SetBool("last_attack",true);
				float step = 4600 * Time.deltaTime;
				transform.position = Vector3.MoveTowards(transform.position, pivot_last_attack.position, step);
				if (transform.position == pivot_last_attack.position) 
				{
					counter = 0;
					anim.SetBool("last_attack",false);
					scene = "final_scene";
				}
			}
		}
		if(scene == "final_scene")
	  	{
			counter++;
			if(counter == 200)
			{
				anim.SetBool("menang",true);
			}
			if(counter > 400)
			{
				anim.SetBool("menang",false);
				_direction = (lookat.position - transform.position).normalized;
				_lookRotation = Quaternion.LookRotation (_direction);
				transform.rotation = Quaternion.Slerp (transform.rotation, _lookRotation, Time.deltaTime * 2);
			}
			if(counter > 1000)
			{
				anim.SetBool("jalan",true);
				_direction = (pivot_exit.position - transform.position).normalized;
				_lookRotation = Quaternion.LookRotation (_direction);
				transform.rotation = Quaternion.Slerp (transform.rotation, _lookRotation, Time.deltaTime * 3);
				float step = 500 * Time.deltaTime;
				transform.position = Vector3.MoveTowards(transform.position, pivot_exit.position, step);
				if (transform.position == pivot_exit.position)
				{
					knight2_mesh.renderer.enabled = false;
					counter =0;
					scene ="end";
				}
			}
		}





	}

}
