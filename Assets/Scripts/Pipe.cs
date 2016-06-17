using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {
	void Start () {
		Rigidbody2D rigidBody = GetComponent<Rigidbody2D> ();
		rigidBody.velocity = new Vector2 (-5f, 0);
	}

	void Update () {
		if (transform.position.x < -10) {
			Destroy (transform.parent.gameObject);
		}
	}
}
