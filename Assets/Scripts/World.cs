using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour {
    public bool gameOver;
    public bool win;
    public int point;
	// Use this for initialization
	void Start () {
        this.gameOver = false;
        this.win = false;
        this.point = 0;
    }
	
	// Update is called once per frame
	void Update () {
	}
}
