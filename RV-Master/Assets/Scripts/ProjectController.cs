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
        float width = Screen.width/5;
        float height = Screen.height/3;
        float sizeX = 50;
        //GUI.DrawTexture(new Rect(50, 70, 100, 100), aTexture, ScaleMode.ScaleToFit, true, 1.0f);
        if (GUI.Button(new Rect(sizeX, 70, width, height), TextureKlp1))
        {
            Application.LoadLevel(1);
        }
        sizeX = sizeX + width + 40;
        if (GUI.Button(new Rect(sizeX, 70, width, height), TextureKlp2))
        {
            Application.LoadLevel(2);
        }
        sizeX = sizeX + width + 40;
        if (GUI.Button(new Rect(sizeX, 70, width, height), TextureKlp3))
        {
            Application.LoadLevel(3);
        }
        sizeX = sizeX + width + 40;
        if (GUI.Button(new Rect(sizeX, 70, width, height), TextureKlp4))
        {
            Application.LoadLevel(4);
        }
        sizeX = 50;
        if (GUI.Button(new Rect(sizeX, 400, width, height), TextureKlp5))
        {
            Application.LoadLevel(5);
        }
        sizeX = sizeX + width + 40;
        if (GUI.Button(new Rect(sizeX, 400, width, height), TextureKlp6))
        {
            Application.LoadLevel(6);
        }
        sizeX = sizeX + width + 40;
        if (GUI.Button(new Rect(sizeX, 400, width, height), TextureKlp7))
        {
            Application.LoadLevel(7);
        }
        sizeX = sizeX + width + 40;
        if (GUI.Button(new Rect(sizeX, 400, width, height), TextureKlp8))
        {
            //Application.LoadLevel(8);
        }
    }
}
