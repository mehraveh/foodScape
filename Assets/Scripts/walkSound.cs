using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkSound : MonoBehaviour {
    public AudioSource footStep;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("a") || Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            footStep.Play();
        }
	}
}
