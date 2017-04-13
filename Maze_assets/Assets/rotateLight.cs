using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLight : MonoBehaviour {

	public GameObject directionalLight;

	// Use this for initialization
	void Start () {
		GvrViewer.Instance.OnTrigger += activateRotation;
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion startRotation = Quaternion.Euler (50f, 30f, 0);
		Quaternion endRotation = Quaternion.Euler (0f, 180f, 0);
		directionalLight.transform.rotation = Quaternion.Slerp (startRotation, endRotation, Time.time / 100f);

	}
	public void activateRotation () {


	}
}
