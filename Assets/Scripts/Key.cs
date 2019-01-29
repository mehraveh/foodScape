using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    public GameObject ColaWalk;
    public GameObject freinchWalk;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	float xColDistance = Mathf.Abs(ColaWalk.transform.position.x - this.transform.position.x);
    float yColDistance = Mathf.Abs(ColaWalk.transform.position.y - this.transform.position.y);
    float xFrDistance = Mathf.Abs(freinchWalk.transform.position.x - this.transform.position.x);
    float yFrDistance = Mathf.Abs(freinchWalk.transform.position.y - this.transform.position.y);
    if ((xColDistance < 0.5 && yColDistance < 1 ) || (xFrDistance < 0.5  && yFrDistance < 1))
        {
            Destroy(this.gameObject, 1f);
            this.ColaWalk = GameObject.Find("cola1");
            ColaWalk colawalk = this.ColaWalk.GetComponent<ColaWalk>();
            colawalk.gotKey = true;

            this.freinchWalk = GameObject.Find("ff3");
            freinchWalk freinchwalk = this.freinchWalk.GetComponent<freinchWalk>();
            freinchwalk.gotKey = true;
        }
    }
}
