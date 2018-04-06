using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splash1 : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey && SceneManager.GetActiveScene ().buildIndex == 2) {
			SceneManager.LoadScene (1);
		}
	}
}
