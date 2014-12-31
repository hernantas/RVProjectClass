using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	// Use this for initialization
	public GameObject knight1;
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
	public GameObject knight2;
	int counter = 0;

	public Animator anim;

	public float RotationSpeed;
	private Quaternion _lookRotation;
	private Vector3 _direction;
	

	void Start () {
		 knight1 = GameObject.Find ("ksatria1");
		 anim = GetComponent<Animator>();
		target =GameObject.Find ("pivot1walkentrybad").transform;
		lookat =GameObject.Find("ImageTarget").transform;
		scene = "scene1";
		knight2= GameObject.Find ("ksatria2");
	}
	
	// Update is called once per frame
	void Update () {
		if (scene == "scene1") 
		{
			anim.SetBool("jalan",true);
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, target.position, step);
			if (transform.position == target.position)
			{
				scene = "scene2";
				anim.SetBool("jalan",false);
			}
		}
		if(scene == "scene2")
		{
				
			_direction = (lookat.position - transform.position).normalized;
			_lookRotation = Quaternion.LookRotation(_direction);
			transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
			counter++;
			if(counter == 500)
			{
				
				scene = "scene3";
				counter =0;
			}
		}
		if(scene == "scene3")
		{
			counter++;
			if(counter == 1)
			{
				anim.SetBool("taunt",true);
			}
			if(counter == 100)
			{
				anim.SetBool("taunt" , false);
			}
			if(counter == 200)
			{
				scene = "scene4";
				counter =0;
			}
		}	

		if (scene == "scene4") 
		{
			_direction = (knight2.transform.position - transform.position).normalized;
			_lookRotation = Quaternion.LookRotation(_direction);
			transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
			counter++;
			if(counter == 50)
			{
				anim.SetBool("evade",true);
				scene = "scene5";
				counter =0;
			}
		}

		if (scene == "scene5") 
		{
			counter++;
			if(counter == 30)
			{
				anim.SetBool("evade",false);
			}
			if(counter == 200)
			{

				scene = "scene6";
				counter =0;
			}
		}

		if (scene == "scene6") 
		{
			counter++;
			if(counter == 100)
		   	{
				anim.SetBool("angry",true);
			}
			if(counter == 130)
			{
				anim.SetBool("angry",false);
				anim.SetBool("battle_ready",true);
			}
			if(counter == 200)
			{
				counter =0;
				scene ="scene7";
			}
		}

		if (scene == "scene7") {
				counter ++;
				anim.SetBool ("battle_ready", false);
				if (counter == 260) {
						anim.SetBool ("blow_back", true);
						counter = 0;
						scene = "scene8";
				}
		}
		if(scene == "scene8")
		{
			counter++;
			if(counter == 40)
			{
					anim.SetBool("blow_back" ,false);
					anim.SetBool("attack_small",true);
			}
			if(counter == 60)
			{
				anim.SetBool("attack_small",false);
			}
			if(counter == 100)
			{
				anim.SetBool("parry_right",true);
			}
			if(counter == 120)
				anim.SetBool("parry_right",false);
			if(counter == 150)
			{
				anim.SetBool("attack_small",true);

			}
			if(counter == 170)
				anim.SetBool("attack_small",false);
			if(counter == 220)
			{
				anim.SetBool("parry_right",true);

			}
			if(counter == 230)
				anim.SetBool("parry_right",false);
			if(counter == 240)
			{
				anim.SetBool("jump_attack",true);
			}
			if(counter == 260)
			{
				anim.SetBool("jump_attack",false);
			}
			if(counter == 280)
			{
			  anim.SetBool("pedang_mental",true);
			}
			if(counter == 300)
			{
				anim.SetBool("pedang_mental",false);
			}
			if(counter == 380)
			{
				anim.SetBool("blok",true);
			}
			if(counter == 400)
			{
				anim.SetBool("blok",false);
			}
			if(counter == 430)
			{
				anim.SetBool("tebas_down",true);
			}
			if(counter == 465)
			{
				anim.SetBool("tebas_down",false);
			}
			if(counter == 455)
			{
				anim.SetBool("tebas_up",true);
			}
			if(counter == 505)
			{
				anim.SetBool ("tebas_up",false);
			}


			if(counter == 525)
			{
				anim.SetBool("blok",true);
			}
			if(counter == 545)
			{
				anim.SetBool("blok",false);
			}
			if(counter == 575)
			{
				anim.SetBool("tebas_down",true);
			}
			if(counter == 600)
			{
				anim.SetBool("tebas_down",false);
			}
			if(counter == 620)
			{
				anim.SetBool("tebas_up",true);
			}
			if(counter == 650)
			{
				anim.SetBool ("tebas_up",false);
				scene = "final scene";
				counter =0;
			}
		}
	if (scene == "final scene") 
		{
			counter++;
			if(counter == 40)
			{
				anim.SetBool("mati",true);
			}
			if(counter == 80)
			{
				anim.SetBool("mati",true);
			}
		}
		
		
	}


}
