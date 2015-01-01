using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
	public AudioClip[] suara;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playSound(int flag) {
		if (flag == 1)
			audio.PlayOneShot (suara [0], 200.0f);
		else 
			audio.Stop ();
	}
}
