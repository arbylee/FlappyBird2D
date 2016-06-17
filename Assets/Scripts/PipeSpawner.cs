using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour {
	public GameObject pipesPrefab;
	private float timeBetweenSpawns = 2f;
	void Start () {
		StartCoroutine (DelayedSpawnPipes ());
	}

	IEnumerator DelayedSpawnPipes(){
		while (true) {
			yield return new WaitForSeconds (timeBetweenSpawns);
			SpawnPipes ();
		}
	}

	void SpawnPipes() {
		float y = Random.Range (-3f, 3f);
		Vector2 spawnPosition = new Vector2(9.5f, y);
		Instantiate (pipesPrefab, spawnPosition, Quaternion.identity);
	}
}
