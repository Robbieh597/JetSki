using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter()
	{
		renderer.material.color = Color.gray;
	}

	void OnMouseExit()
	{
		renderer.material.color = new Color(139,219,240);
	}

	void OnMouseDown() {
		Application.LoadLevel("CollectableColour");
	}
}
