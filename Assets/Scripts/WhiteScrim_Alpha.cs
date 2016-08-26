using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WhiteScrim_Alpha : MonoBehaviour {

	public Slider alpha_slider;

	// Use this for initialization
	void Start () {
		alpha_slider.value = 0.33f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeAlphaOfWhiteScrim(){

		//int myFloat = System.Int16.Parse (textField.text);
		//float.TryParse(textField.text, out myOut)

		///float myOut = 0.33f;

		GetComponent<Image> ().color = new Color (255f, 255f, 255f, alpha_slider.value);
	}

}
