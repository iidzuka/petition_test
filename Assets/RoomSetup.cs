using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RoomSetup : NetworkBehaviour {
	public GameObject tablePrefab;
	public override void OnStartServer () {
		var table = (GameObject)Instantiate(tablePrefab, new Vector3(0, 0, 0), Quaternion.identity);
		NetworkServer.Spawn(table);
	}
}
