﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScene : MonoBehaviour {
	public void GoToScene(string sceneName) {
		SceneManager.LoadScene (sceneName);
		//SceneManager.LoadScene(0);
	}

}
