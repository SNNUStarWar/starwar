using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour 
{
	//public
    public float HP;
    public float DPS;
    public float speed;
    public bool isAlive;
    public GameObject ruledstar;


    //private
    GameObject ship;

    
    // Use this for initialization
    void Awake()
    {
        this.gameObject.GetComponent<Animation>().Stop();
        ship = this.gameObject.transform.Find("shipmode").gameObject;
    }
    void Start () 
    {

	}
	// Update is called once per frame
	void Update () 
    {
		
	}


    public void setRuleStar(GameObject _star)
    {
        ruledstar = _star;
        this.gameObject.transform.position = ruledstar.transform.position;
        // float n=ship.transform.position.x ;
        ship.transform.position = new Vector3(ruledstar.transform.position.x, ruledstar.transform.position.y,  ruledstar.GetComponent<Star>().R);
        this.gameObject.GetComponent<Animation>().Play();
    }
}
