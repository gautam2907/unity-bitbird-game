using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTree : MonoBehaviour {
	public Vector2 speed = new Vector2(-2.0f,0);
	public float x;
	public float y;


	// Use this for initialization
	void Start () {
		x = Random.Range (0.58f, 1.0f);
		y = Random.Range (0.56f,0.96f);
		Vector2 scale = new Vector2 (x, y);
		transform.localScale = scale;
		Vector3 position = new Vector3 (transform.position.x,-3.0f,transform.position.z);
		transform.position = position; 
		 
		
	}

	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity=speed;
		
	}
}
