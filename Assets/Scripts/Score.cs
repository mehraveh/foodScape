using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {
    public Text score;
    public GameObject sc;
	// Use this for initialization
	void Start () {
        int sc = 0;
        this.score.text = sc.ToString();
        this.sc = GameObject.Find("wall");

    }

    // Update is called once per frame
    void Update () {
        World world = sc.GetComponent<World>();
        this.score.text = world.point.ToString();
    }
}
