using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public GameObject ColaWalk;
    public GameObject freinchWalk;
    public GameObject Win;
    public GameObject World;
    public bool colaEntr;
    public bool frEntr;
    // Use this for initialization
    void Start () {
        this.colaEntr = false;
        this.frEntr = false;
	}
	
	// Update is called once per frame
	void Update () {
        float xColDistance = Mathf.Abs(ColaWalk.transform.position.x - this.transform.position.x);
        float yColDistance = Mathf.Abs(ColaWalk.transform.position.y - this.transform.position.y);
        float xFrDistance = Mathf.Abs(freinchWalk.transform.position.x - this.transform.position.x);
        float yFrDistance = Mathf.Abs(freinchWalk.transform.position.y - this.transform.position.y);
        ColaWalk = GameObject.Find("cola1");
        freinchWalk = GameObject.Find("ff3");
        ColaWalk colawalk = ColaWalk.GetComponent<ColaWalk>();
        freinchWalk freinchwalk = freinchWalk.GetComponent<freinchWalk>();
        if (colawalk.gotKey == true || freinchwalk.gotKey == true) {
            Debug.Log("GETTT");
            if (xColDistance < 0.8 && yColDistance < 1)
            {
                this.colaEntr = true;
                // ColaWalk = null;
                Debug.Log("COLAA");


            }
            if (xFrDistance < 0.8 && yFrDistance < 1)
            {
                this.frEntr = true;
                // freinchWalk = null;
                Debug.Log("FRRR");


            }
            if (xColDistance > 0.8 || yColDistance > 1)
            {
                this.colaEntr = false;
                // ColaWalk = null;
                Debug.Log("COLAA1");


            }
            if (xFrDistance > 0.8 || yFrDistance > 1)
            {
                this.frEntr = false;
                // freinchWalk = null;
                Debug.Log("FRRR1");


            }
        }
        this.World = GameObject.Find("wall");
        World world = this.World.GetComponent<World>();
        if(this.colaEntr == true && this.frEntr == true && world.point == 3)
        {

            //this.Win = GameObject.Find("Win");
            //Win win = this.Win.GetComponent<Win>();
            Win.SetActive(true);
            Destroy(ColaWalk.gameObject, 0);
            Destroy(freinchWalk.gameObject, 0);
        }
    }
}

