using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ilhamhe {

	public class BoxSpawner : MonoBehaviour {
		public GameObject box;

		private void Update () {
			if (Input.GetKeyDown (KeyCode.Space)) {
				GameObject go = Instantiate (box, new Vector3 (Random.Range (-7f, 7f), Random.Range (3f, 5f), 0), Quaternion.identity) as GameObject;
				go.transform.localScale = new Vector2(Random.Range(.5f, 1.5f), Random.Range(.5f, 1.5f));
				Destroy(go, 3f);
			}
		}
	}

}