using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help : MonoBehaviour {
    public bool show = false;
    public GameObject men;
    public void onClick()
    {
        if (show)
        {
            men.SetActive(false);
            this.show = false;
        }
        else
        {
            men.SetActive(true);
            this.show = true;
        }
    }
}
