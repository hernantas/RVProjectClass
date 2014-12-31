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

	void playSound() {
		audio.PlayOneShot (suara[0], 100.0f);
	}
}
