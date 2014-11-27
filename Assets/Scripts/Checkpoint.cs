using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	private bool _isVisible;
	public bool IsVisible { get { return _isVisible; } set { _isVisible = value; } }

	private bool _isStartFinish;
	public bool IsStartFinish { get { return _isStartFinish; } set { _isStartFinish = value; } }
	
	// Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update () { }

	public void CollisionDetection()
	{
		//code to handle collison between checkpoint and racers
	}
}
