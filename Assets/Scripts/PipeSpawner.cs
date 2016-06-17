using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour {
	public GameObject pipesPrefab;
	private float timeBetweenSpawns = 1f;
	private Vector2 spawnPosition = new Vector2(9.5f, 0);
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
		Instantiate (pipesPrefab, spawnPosition, Quaternion.identity);
	}
}
