using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splash : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey && SceneManager.GetActiveScene ().buildIndex == 0) {
			SceneManager.LoadScene (1);
		}
	}
}
