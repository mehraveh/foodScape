using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chef : MonoBehaviour {
    int counter = 0;
    public float speed;
  
    // Use this for initialization
    void Start () {

        BargashtEnd();
	}

    
	void RaftEnd()
    {
        StartCoroutine(Move(transform, transform.position, transform.position - new Vector3(4, 0, 0), 2, () =>
        {
            BargashtEnd();
        }));
    }

    void BargashtEnd()
    {
        StartCoroutine(Move(transform, transform.position, transform.position + new Vector3(4, 0, 0), 2,
            () => RaftEnd()
   ));
    }
	// Update is called once per frame
	void Update () {
        //if (counter<=100)
        //{
        //    transform.Translate(Vector2.right * speed * Time.deltaTime);

        //}
        //if (counter > 100)
        //{
        //    transform.Translate(Vector2.left * speed * Time.deltaTime);
        //}
        //if (counter > 200)
        //    counter = 0;
        //counter++;
    }

    IEnumerator Move(Transform trans, Vector3 start, Vector3 end, float time, System.Action callback)
    {
        float i = 0.0f;
        float rate = 1.0f / time;

        while (i <= 1)
        {
            i += Time.deltaTime * rate;

            trans.position = Vector3.Lerp(start, end, i);

            yield return null;

        }
        trans.position = end;

        if (callback != null)
        {
            callback();
        }
    }
}
