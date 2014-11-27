using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RaceManager : MonoBehaviour {

	public List<Racer> Racers = new List<Racer>();

	private int _totalLaps;
	public int TotalLaps{ get{return _totalLaps;} set{ _totalLaps = value; } }
	
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

	public void StartRace()
	{
		//code to start race
	}

	public void EndRace()
	{
		//code to end race
	}
}
