using UnityEngine;
using System.Collections;

public class ProjectSceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 30), "Main Menu"))
        {
            Application.LoadLevel(0);
        }
    }
}
