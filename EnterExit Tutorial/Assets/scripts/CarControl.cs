using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour 
{
	public float speed = 15f;
	public int turnSpeed = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float axisH = Input.GetAxis("Horizontal");
		float axisV = Input.GetAxis("Vertical");
		transform.Translate(Vector3.forward * axisV * speed * Time.deltaTime);
		if (axisV > 0) 
		{
			transform.Rotate(Vector3.up * axisH * turnSpeed * Time.deltaTime);
		}
		else
		{
			transform.Rotate(-Vector3.up * axisH * turnSpeed * Time.deltaTime);
		}
	}
}
