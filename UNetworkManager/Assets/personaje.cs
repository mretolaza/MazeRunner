using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class personaje : NetworkBehaviour {

	int amount = 33;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!isLocalPlayer)
			return;

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody>().AddForce(new Vector3(-amount,0,0));

		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			GetComponent<Rigidbody>().AddForce(new Vector3(amount,0,0));
		
		}


		
	}
}
