using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{


		if (col.gameObject.name == "Player") {
			SceneManager.LoadScene (2);;

		}

	}

}
