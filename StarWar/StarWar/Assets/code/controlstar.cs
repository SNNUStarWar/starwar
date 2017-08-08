using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class controlstar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		coordinate star_position = new coordinate (x, y, z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class coordinate
{
	public float x,y,z;
	public void set_coordinate(float tempx, float tempy, float tempz)
	{
		x = tempx;
		y = tempy;
		z = tempz;
	}
	public coordinate(float tempx, float tempy, float tempz)
	{
		x = tempx;
		y = tempy;
		z = tempz;
	}
	public coordinate(coordinate temp)
	{
		x = temp.x;
		y = temp.y;
		z = temp.z;
	}

};

public class star
{
	public string no_star;
	public coordinate star_coordinate;
	public float mass;   // [100~1000]
	public float radius; // [1~5]
	public float density; // [1~10]
	public int belong_who;
	public int max_number_berth_ship;
	public float produce_ship_per_second;
	public int max_number_build_battery;
	public int number_ship_have;
	public star ()
	{
		;
	}

	public star(string no, coordinate star_position, float tempradius, float tempdensiy, int tempbelong)
	{
		no_star = no;
		star_coordinate = new coordinate (star_position);
		mass = tempdensiy * 0.25f *(float) Math.Pow(tempradius,3)*(float)Math.PI;
		radius = tempradius;
		density = tempdensiy;
		belong_who = tempbelong;
		max_number_berth_ship = (int)radius * 4;
		produce_ship_per_second = mass/1000;
		number_ship_have = 0;
	}

	public int produce_ship()
	{
		//call ship construction function
		// send this star's position 
		return number_ship_have;
	}

	public int send_ship(int num_send, string no_star)       //get which star we want send ship and how many ship we want send
	{
		number_ship_have -= num_send;
		for (int i = 0; i < num_send; i++) 
		{
			//send coordinate of star to this ship;
		}
		return max_number_berth_ship - number_ship_have ; // return how many ship we should produce
	}

	public void adopt_ship ()
	{
		;

	}
} 