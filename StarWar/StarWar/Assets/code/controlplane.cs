using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class controlplane : MonoBehaviour 
{
	public GameObject tempshipmodel;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		

	}
}


class spaceship : MonoBehaviour
{
	//data
	public float HP;
	public float DPS;
	public float speed;
	public bool is_alive;
	public coordinate ship_Position_coordinate;
	public coordinate ship_Rotation_coordinate;
	public coordinate now_star_coordinate;
	public coordinate next_star_coordinate;
	public GameObject shipmodel; 
	public float ship_around_radius;
	public void update_ship_transform(float pos_x)
	{
		ship_Position_coordinate.x = pos_x;
		ship_Position_coordinate.y = 0;
		ship_Position_coordinate.z = (float)Math.Sqrt (4 - (ship_Position_coordinate.x - now_star_coordinate.x) * (ship_Position_coordinate.x - now_star_coordinate.x)) + now_star_coordinate.z;
		Vector3 ship_position = new Vector3 (ship_Position_coordinate.x, ship_Position_coordinate.y, ship_Position_coordinate.z);
		ship_Rotation_coordinate.x = 0.0f;
		ship_Rotation_coordinate.y = (float)(1 / Math.PI) * 180 * (float)Math.Atan ((ship_Position_coordinate.x - now_star_coordinate.x) / (ship_Position_coordinate.z - now_star_coordinate.z));
		ship_Rotation_coordinate.z = -90.0f;	
		Quaternion ship_Rotation = Quaternion.Euler(ship_Rotation_coordinate.x, ship_Rotation_coordinate.y, ship_Rotation_coordinate.z); 
		ship_Position_coordinate.set_coordinate (ship_Position_coordinate.x,ship_Position_coordinate.y,ship_Position_coordinate.z);
		ship_Rotation_coordinate.set_coordinate (ship_Rotation_coordinate.x,ship_Rotation_coordinate.y,ship_Rotation_coordinate.z);
	}
	//function
	public spaceship(GameObject tempship, float thp, float tdps, float tspeed, coordinate nowcoordinate)
	{
		shipmodel = tempship;
		ship_Position_coordinate = new coordinate (0, 0, 0);
		ship_Rotation_coordinate = new coordinate (0, 0, 0);
		HP = thp;
		DPS = tdps;
		speed = tspeed;
		is_alive = true;
		now_star_coordinate = nowcoordinate;
		next_star_coordinate = nowcoordinate;
		ship_Position_coordinate.x = UnityEngine.Random.Range(now_star_coordinate.x - 2.0f, now_star_coordinate.x + 2.0f)+UnityEngine.Random.Range(-1,1);
		update_ship_transform (ship_Position_coordinate.x);
		ship_around_radius = (float)Math.Sqrt ((ship_Position_coordinate.x - now_star_coordinate.x) * (ship_Position_coordinate.x - now_star_coordinate.x) + (ship_Position_coordinate.z - now_star_coordinate.z) * (ship_Position_coordinate.z - now_star_coordinate.z));
		Vector3 ship_position = new Vector3 (ship_Position_coordinate.x, ship_Position_coordinate.y, ship_Position_coordinate.z);
		Quaternion ship_Rotation = Quaternion.Euler(ship_Rotation_coordinate.x, ship_Rotation_coordinate.y, ship_Rotation_coordinate.z); 
		Instantiate (shipmodel, ship_position, ship_Rotation);
		//shipmodel.transform.parent = 
	}

	public void move_around_star()
	{
		float star_time =  Time.timeSinceLevelLoad;
		float now_tiem = Time.timeSinceLevelLoad;
		while (true) 
		{
			if (now_tiem - star_time >= 0.03f)
			{
				float w = ship_around_radius / speed;

			}
			
		}
	}
	public void move_spaceship()
	{

		;
	}


}
