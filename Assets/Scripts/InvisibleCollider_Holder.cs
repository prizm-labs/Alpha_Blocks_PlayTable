using UnityEngine;
using System.Collections;

public class InvisibleCollider_Holder : MonoBehaviour {

	public static InvisibleCollider_Holder Instance;
	public int letter_in_frame_counter;
	public GameObject CAT;


	// Use this for initialization
	void Start () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
