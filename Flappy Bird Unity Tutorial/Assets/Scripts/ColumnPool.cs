using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

	public int columnPoolSize = 5;

	public GameObject columnPrefab;

	public float spawnRate = 4f;

	private GameObject[] columns;

	private Vector2 objectPoolPosition = new Vector2 (-15f, -25f);

	private float timeSinceLastSpawned;

	// Use this for initialization
	void Start () {
		columns = new GameObject[columnPoolSize];

		for (int i = 0; i < columnPoolSize; i++) {
			columns [i] = (GameObject)Instantiate (columnPrefab, objectPoolPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastSpawned += Time.deltaTime;

		if (!GameControl.instance.gameOver && timeSinceLastSpawned >= spawnRate) {
			
		}
	}
}
