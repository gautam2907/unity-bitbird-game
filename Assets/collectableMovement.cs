using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableMovement : MonoBehaviour {
	public Vector2 speed = new Vector2(-6.0f,0);
	public float x;
	public float y;


	// Use this for initialization
	void Start () {
		x = 11;
		y = Random.Range (-3, 5);
		Vector2 position = new Vector2 (x, y);
		transform.position = position;
			
		
	}

	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity=speed;
	}
		
	}

