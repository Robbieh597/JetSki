using UnityEngine;
using System.Collections;
using System.Timers;

public class SpeedBoost : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.name == "Player") 
		{

			c.gameObject.renderer.material.color = this.renderer.material.color;
			Destroy(this.gameObject);	

			Racer r = c.gameObject.GetComponent(typeof(Racer)) as Racer;
				
			r.Speed = 10;
			Debug.Log(r.Speed);


		}

	}
}
