using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject child;
	public float startDelay = 5.0f;
	public float repeatingDelay = 1.0f;

	public Vector3 childStartPosition = new Vector3(0,0,0);
	public float spawnRadius = 15f;
	public float spawnAngle = 360f; 

	void Start()
	{
		InvokeRepeating("SpawnChild", startDelay, repeatingDelay);
	}

	void SpawnChild()
	{
		spawnAngle = Random.value * 360f;

		childStartPosition = new Vector3(spawnRadius * Mathf.Sin (spawnAngle * Mathf.Deg2Rad),
		                                spawnRadius * Mathf.Cos (spawnAngle * Mathf.Deg2Rad),
		                                transform.position.z);
		Instantiate(child, childStartPosition, Quaternion.Euler (0,0, Mathf.Abs(spawnAngle)));
	}
}
