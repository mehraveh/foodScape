using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setAct()
    {
        gameObject.SetActive(true);
    }
}
