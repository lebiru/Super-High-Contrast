using UnityEngine;
using System.Collections;

public class PlayerAutoMove : MonoBehaviour {

	public float movingSpeed = 2.0f;

	public float rotationSpeed = 1.0f;
	public Quaternion rotation;
	public Vector3 radius = new Vector3(0,0,0);
	public float currentRotation = 0.0f;

	void FixedUpdate()
	{
//		currentRotation += Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
//		rotation.eulerAngles = new Vector3 (0, 0, currentRotation);
//		transform.position = new Vector3(transform.position.x + (rotation.x * radius.x), 
//		                                 transform.position.y + (rotation.y * radius.y), 
//		                                 transform.position.z + (movingSpeed * Time.deltaTime));
		transform.position = new Vector3(transform.position.x + (Input.GetAxis("Horizontal") * movingSpeed * Time.deltaTime),
		                                 transform.position.y + (Input.GetAxis("Vertical") * movingSpeed *Time.deltaTime),
		                                 transform.position.z + (movingSpeed * Time.deltaTime));
		//transform.position = rotation * radius;
	}

}
