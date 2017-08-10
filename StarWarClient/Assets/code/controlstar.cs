using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class controlstar : MonoBehaviour {
    public GameObject tempshipmodel;
    // Use this for initialization
    coordinate star_position = new coordinate();
    star newstar = new star();
    void Start () {
        
        float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
        float r = transform.localScale.x;
        star_position.set_coordinate(x, y, z);
        newstar.set_star(tempshipmodel, 1, star_position, r, 0.1f, 1);
        newstar.produce_ship();
        
	}
	
	// Update is called once per frame
	void Update () {
        newstar.produce_ship();
    }

}

public class coordinate
{
	public float x,y,z;
    public coordinate()
    {
        ;
    }
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
	public int no_star;    //no. of a star
	public coordinate star_coordinate;   // 坐标
	public float mass;   // [100~1000]  质量
	public float radius; // [1~5]  半径
	public float density; // [1~10]   密度
	public int belong_who;    //属于哪个玩家
	public int max_number_berth_ship;    //最大飞船停靠数
	public float produce_ship_per_second;   //每秒产生飞船数
	public int max_number_build_battery;    //最大建造防御塔数量
	public int number_ship_have;     //该星球已拥有星球数量
    public GameObject ship_mode;     //飞船的预制模型

    public star()
    {
        ;
    }
	public star(GameObject tshipmode, int no, coordinate star_position, float tempradius, float tempdensiy, int tempbelong)
	{
        ship_mode = tshipmode;
		no_star = no;
		star_coordinate = new coordinate (star_position);
		mass = tempdensiy * 0.25f *(float) Math.Pow(tempradius,3)*(float)Math.PI;
		radius = tempradius;
		density = tempdensiy;
		belong_who = tempbelong;
		max_number_berth_ship = (int)radius * 4;
		produce_ship_per_second = mass/1000;
		number_ship_have = 20;
	}
    public void set_star(GameObject tshipmode, int no, coordinate star_position, float tempradius, float tempdensiy, int tempbelong)
    {
        ship_mode = tshipmode;
        no_star = no;
        star_coordinate = new coordinate(star_position);
        mass = tempdensiy * 0.25f * (float)Math.Pow(tempradius, 3) * (float)Math.PI;
        radius = tempradius;
        density = tempdensiy;
        belong_who = tempbelong;
        max_number_berth_ship = (int)radius * 4;
        produce_ship_per_second = mass / 1000;
        number_ship_have = 20;
        
    }
	public int produce_ship()     
	{
        //call ship construction function
        // send this star's position
        int num = 1;
        spaceship ship = new spaceship(ship_mode, 0.1f, 0.1f, 0.1f, star_coordinate);
        number_ship_have++;
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