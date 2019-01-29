using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oil : MonoBehaviour {
    public GameObject ColaWalk;
    public GameObject gameOver;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xDistant = Mathf.Abs(ColaWalk.transform.position.x - this.transform.position.x);
        float yDistant = ColaWalk.transform.position.y - this.transform.position.y;
        if (xDistant > 0 && xDistant < 1.5 && yDistant > 0 && yDistant < 1.5)
        {
            gameOver.SetActive(true);
            Destroy(ColaWalk.gameObject);
        }
    }
}
