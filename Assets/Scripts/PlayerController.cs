using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Vector2 force;
	private Rigidbody2D rigidBody;

	void Awake () {
		rigidBody = GetComponent<Rigidbody2D> ();
		force = new Vector2 (0, 300);
	}
	

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			rigidBody.velocity = Vector2.zero;
			rigidBody.AddForce (force);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
