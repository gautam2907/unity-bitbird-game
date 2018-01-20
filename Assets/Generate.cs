using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {
	public GameObject Coin;
	public GameObject tree;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("GenerateCoin", 1.0f, 3.0f);
		InvokeRepeating ("GenerateTree", 2.0f, 4.0f);
		 
		
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	void GenerateCoin(){
		Instantiate (Coin);
	}
	void GenerateTree(){
		Instantiate (tree);
	}
	void OnBecameInvisible(){
		Destroy (Coin);
	}
}
