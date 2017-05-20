using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerCamera : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Camera>().enabled = isLocalPlayer;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
