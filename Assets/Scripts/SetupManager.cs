using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using TouchScript.Behaviors;
using TouchScript.Gestures;

public class SetupManager : MonoBehaviour {

	public GameObject BlockPrefab;
	public List<Sprite> BlockSprites;

	public List<GameObject> BlockObjects;


	void Start(){

		foreach (Sprite sprite in BlockSprites) {
			GameObject block = Instantiate (BlockPrefab, new Vector3 (UnityEngine.Random.Range (-9, 9), UnityEngine.Random.Range (-7, 7), -1.0f), Quaternion.identity) as GameObject;
			block.GetComponent<SpriteRenderer> ().sprite = sprite;

		}

		for (int i = 5; i < 8; i++) {
			GameObject block = Instantiate (BlockPrefab, new Vector3 (UnityEngine.Random.Range (-9, 9), UnityEngine.Random.Range (-7, 7), -1.0f), Quaternion.identity) as GameObject;
			block.GetComponent<SpriteRenderer>().sprite = BlockSprites[UnityEngine.Random.Range(0, 5)];
			BlockObjects.Add (block);


		}
	}
}
