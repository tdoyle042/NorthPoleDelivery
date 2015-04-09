using UnityEngine;
using System.Collections;

public class House : Object {

	public GameObject HouseObj;

	public House (GameObject obj)
	{
		HouseObj = obj;
	}

	public void Move(float x, float y, float z)
	{
		HouseObj.transform.Translate(x,y,z);
	}
}
