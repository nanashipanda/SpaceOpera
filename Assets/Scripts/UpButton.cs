using UnityEngine;
using System.Collections;

public class UpButton : MonoBehaviour {
    private bool upbutton = false;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (upbutton)
        {
            //Debug.Log("up");
        }
        upbutton = false;
	}

    public void OnClick()
    {
        upbutton = true;
    }
}
