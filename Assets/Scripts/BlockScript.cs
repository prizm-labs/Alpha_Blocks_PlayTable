using UnityEngine;
using System.Collections;
using System;
using TouchScript.Behaviors;
using TouchScript.Gestures;
using System.Collections.Generic;


public class BlockScript : MonoBehaviour {

	public bool touchingSnapZone;


	void OnEnable(){
		GetComponent<ReleaseGesture> ().Released += ActivateParticles;
	}

	void OnDisable(){
		GetComponent<ReleaseGesture> ().Released -= ActivateParticles;
	}
		
	void ActivateParticles(object sender, EventArgs e){
		Debug.Log("Activate particles");
		if (touchingSnapZone) {
			transform.GetChild (0).GetComponent<ParticleSystem> ().Play ();
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag.Equals ("SnapZone")) {
			Debug.Log ("entering a snapZone");
			transform.rotation = Quaternion.Euler (0, 0, 0);
			transform.position = other.transform.position;
			touchingSnapZone = true;
			InvisibleCollider_Holder.Instance.letter_in_frame_counter++;
			if (InvisibleCollider_Holder.Instance.letter_in_frame_counter >= 3) {
				InvisibleCollider_Holder.Instance.CAT.GetComponent<Animator> ().enabled = true;
			}
		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag.Equals ("SnapZone")) {
			Debug.Log ("exiting a snapZone");
			touchingSnapZone = false;
			InvisibleCollider_Holder.Instance.letter_in_frame_counter--;

		}
	}



}
