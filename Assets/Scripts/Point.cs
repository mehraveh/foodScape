using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
    public GameObject ColaWalk;
    public GameObject freinchWalk;
    public GameObject world1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xColDistance = Mathf.Abs(ColaWalk.transform.position.x - this.transform.position.x);
        float yColDistance = Mathf.Abs(ColaWalk.transform.position.y - this.transform.position.y);
        float xFrDistance = Mathf.Abs(freinchWalk.transform.position.x - this.transform.position.x);
        float yFrDistance = Mathf.Abs(freinchWalk.transform.position.y - this.transform.position.y);
        if ((xColDistance < 0.5 && yColDistance < 1) || (xFrDistance < 0.5 && yFrDistance <1))
        {
            Destroy(this.gameObject, 0f);
            this.world1 = GameObject.Find("wall");
            World world = this.world1.GetComponent<World>();
            world.point = world.point + 1;
            Debug.Log(world.point);
            
           
        }
    }
}
