using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour {
    public GameObject freinchWalk;
    public GameObject gameOver;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xDistant = Mathf.Abs(freinchWalk.transform.position.x - this.transform.position.x);
        float yDistant = freinchWalk.transform.position.y - this.transform.position.y;
        if (xDistant > 0 && xDistant < 1.5 && yDistant > 0 && yDistant < 1.5)
        {
            gameOver.SetActive(true);
            Destroy(freinchWalk.gameObject);
            
        }
    }
}
