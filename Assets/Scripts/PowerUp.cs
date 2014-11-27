using UnityEngine;
using System.Collections;

//enum of power up types
public enum PowerUpType{SpeedBoost,Shield,Rocket,SharkAttack,Wave}

public class PowerUp : MonoBehaviour {

	private bool _visible;
	public bool Visible { get{return _visible;} set{ _visible = value; } }

	private string _name;
	public string Name { get{return _name;} set{ _name = value; } }

	private PowerUpType _type;
	public PowerUpType Type { get{return _type;} set{ _type = value; } }

	// Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update () { 
	}

	public void CollisionDetection()
	{
		//code to handle collision detection
	}
}
