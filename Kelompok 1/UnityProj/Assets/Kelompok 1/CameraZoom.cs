using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {
	public float zoomSpeed = 5.0f;
	private int curIndex = -1;
	private GameObject curPlanet = null;
	private ArrayList planets;
	private Vector3 zoomDistance;
	public float delay = 0;
	private bool viewLock = false;

	// Use this for initialization
	void Start () {
		planets = new ArrayList ();
		planets.Add("Matahari");
		planets.Add("Merkurius");
		planets.Add("Venus");
		planets.Add("Bumi");
		planets.Add("Mars");
		planets.Add("Jupiter");
		planets.Add("Saturnus");
		planets.Add("Uranus");
		planets.Add("Neptunus");
		planets.Add("Pluto");
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
	void Update () {
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

		if (viewLock)
			delay -= Time.deltaTime;
	}
}
