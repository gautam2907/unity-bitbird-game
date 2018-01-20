using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerControler : MonoBehaviour {
	public Vector2 jumpforce = new Vector2 (0, 70);
	int Score=0;
	AudioSource Coinaudio,gameoverAudio,ScriptHolderaudio;
	public GameObject GameoverObject;
	public GameObject ScriptHolderObject;
	public Text scoreText;


	// Use this for initialization
	void Start () {
		Coinaudio = GetComponent<AudioSource> ();
		gameoverAudio = GameoverObject.GetComponent<AudioSource> ();
		ScriptHolderaudio = ScriptHolderObject.GetComponent<AudioSource> (); 

	
	}



	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") ||Input.touchCount == 1) {
			GetComponent<Rigidbody2D> ().AddForce (jumpforce);
		}
	}
		//if (Input.GetKeyUp("space"))
		//	{
			//	GetComponent<Rigidbody2D>().AddForce(jumpforce);
			//}
		void OnTriggerEnter2D(Collider2D colObject)
		{
		Debug.Log ("Collision");
			if(colObject.gameObject.CompareTag("Enemy"))
			{
			Destroy (gameObject);
			Debug.Log("Enemy collided " + "game over");
			GameoverObject.SetActive (true);
			gameoverAudio.Play ();
			ScriptHolderaudio.Stop ();


			}
		else if(colObject.gameObject.CompareTag("Collectable"))
			{
			
			Destroy (colObject.gameObject);
			Coinaudio.Play ();
			scoreText.text = "Score: " + ++Score;


					print("Score"+ Score);
			}
			
	}




}
				

				
			

	

			
			
		


