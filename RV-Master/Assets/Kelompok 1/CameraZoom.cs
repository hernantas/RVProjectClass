using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraZoom : MonoBehaviour {
	public float zoomSpeed = 5.0f;
	private int curIndex = -1;
	private GameObject curPlanet = null;
	private List<string> planets;
	private Vector3 zoomDistance;
	public float delay = 0;
	private bool viewLock = false;

	// Use this for initialization
	void Start () {
		planets = new List<string>();
		planets.Add("Matahari");
		planets.Add("Merkurius");
		planets.Add("Venus");
		planets.Add("Bumi");
		planets.Add("Mars");
		planets.Add("Jupiter");
		planets.Add("Sphere");
		planets.Add("Uranus");
		planets.Add("Neptunus");
		planets.Add("Pluto");
		planets.Add ("mauriceh_spaceship_model");
		planets.Add ("Junkyard Spaceship");
	}

	public static float MinMax(float min, float max, float value)
	{
		if (value < min)
			return min;
		else if (value > max)
			return max;
		else
			return value;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        GameObject marker = GameObject.Find("ImageTarget");
        Debug.Log(Vector3.Distance(marker.transform.position, Camera.main.transform.position));

        /*
		if (delay <= 0)
		{
			curIndex ++;
			delay = 8.0f;
			viewLock = false;
			if (curIndex >= planets.Count)
				curIndex = 0;
		}

        float scale = 740;
		GameObject marker = GameObject.Find ("ImageTarget");
		GameObject go = GameObject.Find ("solarsystem_plain_texture");
		GameObject focus = GameObject.Find(planets[curIndex].ToString());
		MeshFilter filter = focus.GetComponent<MeshFilter> (); 
		float avgSize  = (filter.mesh.bounds.size.x + filter.mesh.bounds.size.y + filter.mesh.bounds.size.z)/3;
        Vector3 centerTarget = go.transform.localRotation *  focus.transform.localPosition * scale;
        Vector3 center = marker.transform.position +
            (marker.transform.rotation * new Vector3(0, avgSize * scale * 4, 0));

		Vector3 focusPos = center - centerTarget;

		// Smooth
		Vector3 direction = focusPos - go.transform.position;
		float distance = Vector3.Distance (focusPos, go.transform.position);

        if (distance < 0.3 * scale)
			viewLock = true;

        if (viewLock)
        {
            go.transform.position = focusPos;
            delay -= Time.deltaTime;
        }
        else
			go.transform.position += (direction.normalized * distance * Time.deltaTime);
        */
        /*
		if (curPlanet != null)
		{
			Vector3 targetPos = curPlanet.transform.position + zoomDistance;
			Vector3 direction = targetPos - this.transform.position;
			//float distanceToPlanet = Vector3.Distance(this.transform.position, curPlanet.transform.position);
			//float distanceTargetToPlanet = Vector3.Distance(targetPos, curPlanet.transform.position);
			float distanceToTarget = Vector3.Distance(this.transform.position, targetPos);
			zoomSpeed = distanceToTarget;
			this.transform.position += (direction.normalized * zoomSpeed * Time.deltaTime);

			if (distanceToTarget < 1.0f)
			{
				//this.transform.position = targetPos;
				viewLock = true;
			}

			Quaternion targetRotation = Quaternion.LookRotation(curPlanet.transform.position - transform.position);
			this.transform.rotation =  Quaternion.Slerp(transform.rotation, targetRotation, 2 * Time.deltaTime);
			//this.transform.LookAt (curPlanet.transform.position);
		}

		if (delay <= 0)
		{
			curIndex ++;
			if (curIndex >= planets.Count)
				curIndex = 0;

			curPlanet = GameObject.Find (planets [curIndex].ToString());
			float size = 0;
			size += curPlanet.GetComponent<MeshFilter>().mesh.bounds.size.x;
			size += curPlanet.GetComponent<MeshFilter>().mesh.bounds.size.y;
			size += curPlanet.GetComponent<MeshFilter>().mesh.bounds.size.z;
			size = size/3;
			Vector3 directionSunToPlanet = GameObject.Find("Matahari").transform.position - curPlanet.transform.position;
			directionSunToPlanet.y = 0;
			directionSunToPlanet.Normalize();
			directionSunToPlanet.x -= 0.5f;
			directionSunToPlanet.z -= 0.25f;
			directionSunToPlanet.y += 0.5f;
			directionSunToPlanet.Normalize();
			//if (planets[curIndex] == "Matahari")
				//directionSunToPlanet = new Vector3(0,0,0);

			zoomDistance = directionSunToPlanet * size * 2;
			//zoomDistance = (new Vector3(-1.5f,3,-1.5f) * size);
			delay = 8.0f;
			viewLock = false;
			Debug.Log(planets[curIndex] + "(" + zoomDistance + ")");
		}
		*/
	}
}
