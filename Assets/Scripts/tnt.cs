using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tnt : MonoBehaviour {

    public GameObject chef;
    public AudioSource destroy;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xDistant = Mathf.Abs(chef.transform.position.x - this.transform.position.x);
        float yDistant = chef.transform.position.y - this.transform.position.y;
        if (xDistant > 0 && xDistant < 2 && yDistant > 0 && yDistant < 1.5)
        {
            destroy.Play();
            Destroy(chef.gameObject,3f);
            Destroy(this.gameObject,3f);
            
        }
    }
}
