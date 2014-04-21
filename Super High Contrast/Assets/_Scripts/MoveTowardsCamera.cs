using UnityEngine;
using System.Collections;

public class MoveTowardsCamera : MonoBehaviour {

	public float speed = 1.0f;
	
	void FixedUpdate () 
	{
		rigidbody.transform.position += new Vector3 (0, 0, -speed * Time.deltaTime);
	}
}
