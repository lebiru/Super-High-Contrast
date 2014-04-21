using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour {

	public GameObject target = null;
	private Vector3 positionOffset = Vector3.zero;

	private void Start()
	{
		positionOffset = transform.position - target.transform.position;
	}

	private void FixedUpdate()
	{
		if (target != null) 
		{
			transform.LookAt(target.transform);
			transform.position = new Vector3(0f,0f, target.transform.position.z + positionOffset.z);
		}
	}
}
