using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    // The object we want the camera to follow.
    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        //"transform" without an object refers to "this" object - the one the script is attached to. 
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
	}
}
