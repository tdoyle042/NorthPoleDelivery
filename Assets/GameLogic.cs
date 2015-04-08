using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {
	
	public ArrayList houses;

	public GameObject template1;
	public GameObject template2;
	public GameObject template3;

	public const int MAX_LANE_LOAD = 10;
	public const int MAX_TOTAL_LOAD = 20;

	public int lane1Load;
	public int lane2Load;
	public int lane3Load;

	// Use this for initialization
	void Start () {
		houses = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
		while(lane1Load + lane2Load + lane3Load < MAX_TOTAL_LOAD) {
			AddNewHouse();
		}

		foreach(GameObject house in houses) {
			// Move the houses down the screen
			float translateAmt = Time.deltaTime * 10;
			house.transform.Translate(0.0f,0.0f,translateAmt);
		}
	}

	void AddNewHouse () {

	}

	void HandGrabbed () {
	
	}

	void HandReleased () {
	
	}
}
