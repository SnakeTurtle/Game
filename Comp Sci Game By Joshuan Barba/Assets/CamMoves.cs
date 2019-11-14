using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoves : MonoBehaviour {

    public GameObject Player;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 Cam = new Vector3(Player.transform.position.x + 5, 0, -10);
        transform.position = Cam;

    }

}
