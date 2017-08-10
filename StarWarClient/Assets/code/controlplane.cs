using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class controlplane : MonoBehaviour 
{
    // Use this for initialization
    void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
       
	}
}


public class spaceship : MonoBehaviour
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

    //function
    public spaceship()
    {
        ;
    }

    public spaceship(GameObject tempship, float thp, float tdps, float tspeed, coordinate now_s_coordinate)  //construction function
    {
        shipmodel = tempship;
        HP = thp;
        DPS = tdps;
        speed = tspeed;
        is_alive = true;
        now_star_coordinate = now_s_coordinate;
        next_star_coordinate = now_star_coordinate;
        ship_around_radius = UnityEngine.Random.Range(1.0f, 2.0f);
        ship_Position_coordinate = new coordinate(now_star_coordinate.x , now_star_coordinate.y, now_star_coordinate.z + ship_around_radius);
        ship_Rotation_coordinate = new coordinate(0.0f,0.0f,90.0f);
        Vector3 ship_position = new Vector3(ship_Position_coordinate.x, ship_Position_coordinate.y, ship_Position_coordinate.z);
        Quaternion ship_Rotation = Quaternion.Euler(ship_Rotation_coordinate.x, ship_Rotation_coordinate.y, ship_Rotation_coordinate.z);
        Instantiate(shipmodel, ship_position, ship_Rotation);
    }

    public void update_ship_transform(float pos_x)    
    {

        // ship_Position_coordinate.z = 
    }

    public void move_ship()          //let ship move around the star
    {
        ship_Position_coordinate.x += speed;
        update_ship_transform(ship_Position_coordinate.x);
    }

	/*public void update_ship_transform(float pos_x)
	{
		ship_Position_coordinate.x = pos_x;
		ship_Position_coordinate.y = 0;
		ship_Position_coordinate.z = (float)Math.Sqrt (ship_around_radius*ship_around_radius - (ship_Position_coordinate.x - now_star_coordinate.x) * (ship_Position_coordinate.x - now_star_coordinate.x))+now_star_coordinate.z;
		Vector3 ship_position = new Vector3 (ship_Position_coordinate.x, ship_Position_coordinate.y, ship_Position_coordinate.z);
		ship_Rotation_coordinate.x = 0.0f;
		ship_Rotation_coordinate.y = (float)(1 / Math.PI) * 180 * (float)Math.Atan ((ship_Position_coordinate.x - now_star_coordinate.x) / (ship_Position_coordinate.z - now_star_coordinate.z));
		ship_Rotation_coordinate.z = -90.0f;	
		Quaternion ship_Rotation = Quaternion.Euler(ship_Rotation_coordinate.x, ship_Rotation_coordinate.y, ship_Rotation_coordinate.z); 
		ship_Position_coordinate.set_coordinate (ship_Position_coordinate.x,ship_Position_coordinate.y,ship_Position_coordinate.z);
		ship_Rotation_coordinate.set_coordinate (ship_Rotation_coordinate.x,ship_Rotation_coordinate.y,ship_Rotation_coordinate.z);
	}
	//function
	
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
	}*/


}
