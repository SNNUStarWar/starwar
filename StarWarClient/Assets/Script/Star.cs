using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {
	//public
	public float R = 10	;
	public float time;
	public GameObject SpaceShipPrefab;
	// Use this for initialization
	void Start () {
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (time < Time.time)
		{
			time += 4f;
			Product();
		}
	}

	public void Product()
	{
		GameObject ship =Instantiate( (GameObject)Resources.Load("Prefab/ship"), this.transform.position, this.transform.rotation);
		ship.GetComponent<SpaceShip>().setRuleStar(this.gameObject);
	}
}
