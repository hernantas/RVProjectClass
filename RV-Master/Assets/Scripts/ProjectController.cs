using UnityEngine;
using System.Collections;

public class ProjectController : MonoBehaviour {
    /*
    public string namaSceneKlp1;
    public string namaSceneKlp2;
    public string namaSceneKlp3;
    public string namaSceneKlp4;
    public string namaSceneKlp5;
    public string namaSceneKlp6;
    public string namaSceneKlp7;
    public string namaSceneKlp8;*/
    public Texture TextureKlp1 = new Texture();
    public Texture TextureKlp2 = new Texture();
    public Texture TextureKlp3 = new Texture();
    public Texture TextureKlp4 = new Texture();
    public Texture TextureKlp5 = new Texture();
    public Texture TextureKlp6 = new Texture();
    public Texture TextureKlp7 = new Texture();
    public Texture TextureKlp8 = new Texture();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnGUI()
    {
        //GUI.DrawTexture(new Rect(50, 70, 100, 100), aTexture, ScaleMode.ScaleToFit, true, 1.0f);
        if (GUI.Button(new Rect(50, 70, 300, 300), TextureKlp1))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(360, 70, 300, 300), TextureKlp2))
        {
            Application.LoadLevel(2);
        }
        if (GUI.Button(new Rect(670, 70, 300, 300), TextureKlp3))
        {
            Application.LoadLevel(3);
        }
        if (GUI.Button(new Rect(980, 70, 300, 300), TextureKlp4))
        {
            Application.LoadLevel(4);
        }
        if (GUI.Button(new Rect(50, 400, 300, 300), TextureKlp5))
        {
            Application.LoadLevel(5);
        }
        if (GUI.Button(new Rect(360, 400, 300, 300), TextureKlp6))
        {
            Application.LoadLevel(6);
        }
        if (GUI.Button(new Rect(670, 400, 300, 300), TextureKlp7))
        {
            Application.LoadLevel(7);
        }
        if (GUI.Button(new Rect(980, 400, 300, 300), TextureKlp8))
        {
            //Application.LoadLevel(8);
        }
    }
}
