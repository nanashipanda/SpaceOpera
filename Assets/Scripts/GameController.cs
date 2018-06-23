using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    //すべてのシェイプのスピードを管理
    public float shape_speed;

    //以下ボタンの管理
    public bool rightbutton = false;
    public bool upbutton = false;
    public bool leftbutton = false;
    public bool downbutton = false;
    public bool isPause = false;
    public bool isFire = false;
    //オーディオソース
    public AudioSource Normal;
    
	// Use this for initialization
	void Start () {
        shape_speed = 0.05f;
        Normal = GetComponent<AudioSource>();
        Normal.pitch = 1.0f;

	}
	
	// Update is called once per frame
	void Update () {
	}

    //ポーズ画面の処理（メニューの追加など要修正)
    public void Pause()
    {
        if (isPause == false)
        {
            Time.timeScale = 0;
            Normal.volume = 0.4f;
            isPause = true;
        }
        else
        {
            Time.timeScale = 1;
            Normal.volume = 1.0f;
            isPause = false;
        }
    }

    public void Fire()
    {
        if (isPause == false)
        {
            Debug.Log("Fire");
        }
    }

    public void RightButtonDown()
    {
        if(isPause == false) rightbutton = true;
    }

    public void UpButtonDown()
    {
        if (isPause == false) upbutton = true;

    }

    public void LeftButtonDown()
    {
        if (isPause == false) leftbutton = true;
    }

    public void DownButtonDown()
    {
        if (isPause == false) downbutton = true;
    }

    public void RightButtonUp()
    {
        if (isPause == false) rightbutton = false;
    }

    public void UpButtonUp()
    {
        if (isPause == false) upbutton = false;

    }

    public void LeftButtonUp()
    {
        if (isPause == false) leftbutton = false;
    }

    public void DownButtonUp()
    {
        if (isPause == false) downbutton = false;
    }
}
