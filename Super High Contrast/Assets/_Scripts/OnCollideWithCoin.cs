using UnityEngine;
using System.Collections;

public class OnCollideWithCoin : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Coin") 
		{
			Destroy (col.gameObject);
			audio.Play ();
		}
	}

}
