using UnityEngine;
using System.Collections;


public class ShapeController : MonoBehaviour {
    private float shape_speed = 0.1f;
    //回転フラグ
    private bool rf = true;

    GameObject GameController;

    public bool rightbutton = false;
    public bool upbutton = false;
    public bool leftbutton = false;
    public bool downbutton = false;

    //Debugフラグ
    //private bool df = true;
	// Use this for initialization
	void Start () {
        GameController = GameObject.Find("GameController");
        //RightButton = GameObject.Find("RightButton");
	}
	
	// Update is called once per frame
 


    //Update内を軽くする必要？
    //→ボタンが押されたかどうかのみ判別して関数呼び出し
    void Update () {
        rightbutton = GameController.GetComponent<GameController>().rightbutton;
        upbutton = GameController.GetComponent<GameController>().upbutton;
        leftbutton = GameController.GetComponent<GameController>().leftbutton;
        downbutton = GameController.GetComponent<GameController>().downbutton;

        //if (Input.GetButtonDown(")) { Debug.Log("Push!!"); }
        

        //z軸の回転数取得
        float zEuler = transform.localEulerAngles.z;

        /*
        if(df == true)
        {
            Debug.Log(zEuler);
            df = false;
        }
        */

        //右から
        if (zEuler < 90.0f)
        {
            if (transform.position.y >= -0.7f && transform.position.y <= 0.7f 
                && transform.position.x <= 0.7f && transform.position.x >= -0.7f)
            //交差点内にいるときにキー入力に反応する
            {
                //上
                if (Input.GetKey("w") || upbutton)
                {
                    if (rf == true)
                    {
                        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f), -90.0f);
                        rf = false; //1回回転したらフラグ折る
                        //transform.position = new Vector2(-(0.35f), 0.35f); //位置調整
                        transform.position = new Vector2(-(0.35f), 0.0f); //0版
                    }
                }
                //下
                else if (Input.GetKey("s") || downbutton)
                {
                    if (rf == true)
                    {
                        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f), 90.0f);
                        rf = false; //1回回転したらフラグ折る
                        //transform.position = new Vector2(0.35f, -(0.35f));
                        transform.position = new Vector2(0.35f, 0.0f);
                    }
                }
            }
        }

        //上から
        else if (zEuler >= 90.0f && zEuler < 180.0f) //なぜかif(z角度 == 270)だと反応しないのでとりあえずこれで
        {
            if (transform.position.y >= -0.7f && transform.position.y <= 0.7f 
                && transform.position.x <= 0.7f && transform.position.x >= -0.7f)
            //交差点内にいるときにキー入力に反応する
            {
                //右
                if (Input.GetKey("d") || rightbutton)
                {
                    if (rf == true)
                    {
                        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f), 90.0f);
                        rf = false; //1回回転したらフラグ折る
                        //transform.position = new Vector2(0.35f, 0.35f); //位置調整
                        transform.position = new Vector2(0.0f, 0.35f); //位置調整
                    }
                }
                //左
                else if (Input.GetKey("a") || leftbutton)
                {
                    if (rf == true)
                    {
                        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f), -90.0f); //とにかく左に回転
                        rf = false; //1回回転したらフラグ折る
                        //transform.position = new Vector2(-(0.35f), -(0.35f));
                        transform.position = new Vector2(0.0f, -(0.35f));
                    }
                }
            }
        }

        //左から
        else if (zEuler >= 180.0f && zEuler < 270.0f)
        {
            if (transform.position.y >= -0.7f && transform.position.y <= 0.7f 
                && transform.position.x <= 0.7f && transform.position.x >= -0.7f)
            //交差点内にいるときにキー入力に反応する
            {
                //上
                if (Input.GetKey("w") || upbutton)
                {
                    if (rf == true)
                    {
                        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f), 90.0f);
                        rf = false; //1回回転したらフラグ折る
                        //transform.position = new Vector2(-(0.35f), 0.35f); //位置調整
                        transform.position = new Vector2(-(0.35f), 0.0f); //位置調整
                    }
                }
                //下
                else if (Input.GetKey("s") || downbutton)
                {
                    if (rf == true)
                    {
                        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f), -90.0f);
                        rf = false; //1回回転したらフラグ折る
                        //transform.position = new Vector2(0.35f, -(0.35f));
                        transform.position = new Vector2(0.35f, -0.0f);
                    }
                }
            }
        }

        //下から
        else if (zEuler >= 270.0f)
        {
            if (transform.position.y >= -0.7f && transform.position.y <= 0.7f 
                && transform.position.x <= 0.7f && transform.position.x >= -0.7f)
            //交差点内にいるときにキー入力に反応する
            {
                //右
                if (Input.GetKey("d") || rightbutton)
                {
                    if (rf == true)
                    {
                        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f), -90.0f);
                        rf = false; //1回回転したらフラグ折る
                        //transform.position = new Vector2(0.35f, 0.35f); //位置調整
                        transform.position = new Vector2(0.0f, 0.35f); //位置調整
                    }
                }
                //左
                else if (Input.GetKey("a") || leftbutton)
                {
                    if (rf == true)
                    {
                        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f), 90.0f);
                        rf = false; //1回回転したらフラグ折る
                        //transform.position = new Vector2(-(0.35f), -(0.35f));
                        transform.position = new Vector2(0.0f, -(0.35f));
                    }
                }
            }
        }
    }

    void FixedUpdate()
    {
        shape_speed = GameController.GetComponent<GameController>().shape_speed;
        transform.Translate(-shape_speed, 0.0f, 0.0f);
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
