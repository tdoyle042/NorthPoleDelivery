using UnityEngine;
using System.Collections;


public class GameLogic : MonoBehaviour {
	
	public ArrayList houses;

	public GameObject template1;
	public GameObject template2;
	public GameObject template3;

	public const int MAX_LANE_LOAD = 10;
	public const int MAX_TOTAL_LOAD = 20;

	public const int START_HOUSE_SPEED = -3;

	public int lane1Load;
	public int lane2Load;
	public int lane3Load;

	private System.Random numGenerator;

	// Use this for initialization
	void Start () {
		houses = new ArrayList();
		numGenerator =  new System.Random();

		AddNewHouse(template1);
		AddNewHouse(template2);
		AddNewHouse(template3);


	}
	
	// Update is called once per frame
	void Update () {
		while(lane1Load + lane2Load + lane3Load < MAX_TOTAL_LOAD) {
			int numToTry = numGenerator.Next(0,3);

			switch (numToTry) {
			case 0:
				AddNewHouse(template1);
				break;
			case 1:
				AddNewHouse(template2);
				break;
			default:
				AddNewHouse(template3);
				break;
			}
		}

		foreach(House house in houses) {
			// Move the houses down the screen
			float translateAmt = Time.deltaTime * START_HOUSE_SPEED;
			house.Move(0.0f,0.0f,translateAmt);
		}
	}

	void AddNewHouse (GameObject templateHouse) {
		GameObject newHouseObj = Instantiate(templateHouse);
		House newHouse = new House(newHouseObj);

		houses.Add(newHouse);
	}

	/* 
	 *	ZDK Methods
	 */

//	void Zig_UserFound(ZigTrackedUser user) {
//	
//	}
//
//	void Zig_UserLost(ZigTrackedUser user) {
//		
//	}

	public void Session_Start(Vector3 focusPoint) {
		Debug.Log("Hand Tracking Session Started");
	}

	public void SessionUpdate(Vector3 handPoint) {
		Debug.Log("Update to Hand Tracking");
		Debug.Log (handPoint);
	}

	public void Session_End() {
		Debug.Log("Hand Tracking Session Ended");
	}
}
