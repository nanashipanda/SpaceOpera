using UnityEngine;
using System.Collections;

public class DestroyCube : MonoBehaviour {

    
    public int ColorFlag;/*現在の色の識別
                            0:クリーン
                            1:オレンジ
                            2:グリーン
                            3:ブルー*/

    //現在のシェイプ数
    public int num;
	// Use this for initialization
	void Start () {
        ColorFlag = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        /*******************************************************/
        //                                                      
        //ぶつかったらとりあえずGameControllerに今の状態を送るのが最適？？//
        //
        //////////////////////////////////////////////////////*/

        //とりあえずシェイプ削除
        Destroy(coll.gameObject);
        //UFOが来た場合問答無用でクリーン状態
        if (coll.tag == "UFO")
        {
            ColorFlag = 0;
            ////////////////////
            //ここにスコア処理を挟む//
            ////////////////////
            num = 0;
        }
        //来た色がオレンジの場合
        else if (coll.tag == "Orange")
        {
            if (ColorFlag == 1) num++; //ここで5個以上かの判定？
            else
            {   //else文の中で5個以上かの判定?
                num = 1;
                ColorFlag = 1;
            }
        }

        //来た色がグリーンの場合
        else if (coll.tag == "Green")
        {
            if (ColorFlag == 2) num++; //ここで5個以上かの判定？
            else
            {   //else文の中で5個以上かの判定?
                num = 1;
                ColorFlag = 2;
            }
        }

        //来た色がブルーの場合
        else if (coll.tag == "Blue")
        {
            if (ColorFlag == 3) num++; //ここで5個以上かの判定？
            else
            {   //else文の中で5個以上かの判定?
                num = 1;
                ColorFlag = 3;
            }
        }
    }
}
