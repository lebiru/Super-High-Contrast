using UnityEngine;
using System.Collections;

public class OnCollideWithWall : MonoBehaviour {

	public AudioSource collideWithWall;


	void Start()
	{


	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Wall") 
		{
			Destroy (col.gameObject);
			Camera.main.GetComponent<RandomShake>().PlayShake();
			//collideWithWall.Play();
		}
	}
}
