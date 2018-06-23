using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShapeSprite : MonoBehaviour {
    
    Sprite simage = Resources.Load<Sprite>("Texture/OrangeAlien");
    GameObject Orange;

	// Use this for initialization
	void Start () {
        Orange = new GameObject("Orange");
        Orange.AddComponent<SpriteRenderer>().sprite = simage;
        Orange.transform.localPosition = new Vector3(0f, 0f, 0f);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
