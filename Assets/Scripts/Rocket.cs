using UnityEngine;
using System.Collections;
using System;

public class Rocket : PowerUp
{
	Ray ray;
	RaycastHit hit;
	float distance = 100f;
	public float speed = 5f;
	public GameObject target = null;
	Vector3[] directionPoints = new Vector3[18];

	public Transform explosionEffect;

	public int fuel = 300;

	public float force;
	public float radius;

	// Use this for initialization
	void Start ()
	{ 
		int intervals = 10;
		int y = 0;
		for (int i = 0; i < directionPoints.Length; i++) 
		{
			//create points at 10 degree intervals from 0 to -90;
			if(i < 9)
				directionPoints[i] = Quaternion.Euler(0,-(i*intervals),0) * transform.forward;
			//create points at 10 degree intervals from 0 to 90;
			else
			{
				directionPoints[i] = Quaternion.Euler(0,(y*intervals),0) * transform.forward;
				y++;
			}
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		//find target for first time or follow target
		if (target == null) 
		{
			FindTarget ();
		} 
		else 
		{
			if (fuel > 0) 
			{
				fuel--;
				follow ();
			}
			else
			{
				Instantiate(explosionEffect,transform.position,transform.rotation);
				Destroy(this.gameObject);
				AddExplosionForce ();
			}
		}
	
	}

	void OnCollisionEnter(Collision col)
	{
		//destroys rocket and player when they collide
		if (col.gameObject == target) 
		{
			Instantiate(explosionEffect,transform.position,transform.rotation);
			Destroy (this.gameObject);
			Destroy (target);

			AddExplosionForce ();
		}

	}

	void follow ()
	{
		//rotate rocket to look at player
		transform.LookAt (target.transform);
		//move rocket forward
		transform.position += transform.forward * speed * Time.deltaTime;
	}

	void FindTarget()
	{				
		for (int i = 0; i < directionPoints.Length; i++) {
			Vector3 direction = (directionPoints [i] - transform.position).normalized;
			ray = new Ray (transform.position, direction);
			//draw ray in scene w
			Debug.DrawRay (ray.origin, ray.direction);
			//cast ray
			if (Physics.Raycast (ray, out hit, distance)) {
				//check collision to see if it is a racer
				if (hit.collider.tag == "Racer") {
					target = hit.collider.gameObject;
					break;
				}
			}
		}
		}

	void AddExplosionForce ()
	{
		Ray ray = new Ray (target.transform.position, (transform.position - target.transform.position));
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 100)) {
			Collider[] colliders = Physics.OverlapSphere (hit.point, radius);
			foreach (Collider c in colliders) {
				if (c.rigidbody == null)
					continue;
				c.rigidbody.AddExplosionForce (force, hit.point, radius, 0, ForceMode.Impulse);
			}
		}
	}
}
