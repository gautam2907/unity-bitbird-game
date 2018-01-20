using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReload : MonoBehaviour {

	// Use this for initialization
	public void Reload(){
		SceneManager.LoadScene ("gameiipc", LoadSceneMode.Single);

	}
}
