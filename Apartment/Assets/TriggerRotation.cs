using UnityEngine;
using System.Collections;

public class TriggerRotation : MonoBehaviour {
	public string AnimationName;
	public Animator stateMachine; 
	void Update() {
		if (GvrViewer.Instance.Triggered)
			stateMachine.SetTrigger(AnimationName); 
	}

}