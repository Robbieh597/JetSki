using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Racer : MonoBehaviour {

	private int _speed;
	public int Speed { get{return _speed;} set{ _speed = value; } }

	private int _health;
	public int Health{ get{return _health;} set{ _health = value; } }

	private int _racePos;
	public int RacePos{ get{return _racePos;} set{ _racePos = value; } }

	public List<PowerUp> PowerUps = new List<PowerUp>();

	private float _lapTime;
	public float LapTime{ get{return _lapTime;} set{ _lapTime = value; } }
	
	private float _totalTime;
	public float TotalTime{ get{return _totalTime;} set{ _totalTime = value; } }

	private int _currentLap;
	public int CurrentLap{ get{return _currentLap;} set{ _currentLap = value; } }

	// Use this for initialization
	void Start () {	}
	
	// Update is called once per frame
	void Update () { }

	public void ActivatePowerUp(PowerUp p)
	{
		//code to use power up
	}

	public void AddPowerUp(PowerUp p)
	{
		//adds collected power up to list of power ups
		PowerUps.Add (p);
	}

	public void RemovePowerUp(PowerUp p)
	{
		//removes used power up from list of power ups
		PowerUps.Remove (p);
	}

	public void CollisionDetection()
	{
		//code to handle collision detection
	}
}
