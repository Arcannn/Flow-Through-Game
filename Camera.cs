using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
	public player player1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
    if (!player1.GameOver) transform.position += new Vector3(5 * Time.
		  deltaTime, 0, 0);

	}
}
