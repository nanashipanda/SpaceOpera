using UnityEngine;
using System.Collections;

public class NewShapeController : MonoBehaviour
{
    //size : 4 ... 0~3にそれぞれ Orange, Green, Blue, UFOを格納
    public GameObject[] shape;

    //shape生成間隔
    public float timeOut = 1.5f;
    // Use this for initialization
    void Start()
    {
        //Instantiate(shape[0], new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        StartCoroutine(NewShape());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator NewShape()
    {
        while (true)
        {
            switch (Random.Range(0, 4))
            {
                case 0:
                    Instantiate(shape[Random.Range(0, 3)], new Vector3(6.0f, -0.35f, 0.0f), Quaternion.Euler(0.0f, 0.0f, 0.0f));
                    break;
                case 1:
                    Instantiate(shape[Random.Range(0, 3)], new Vector3(0.35f, 6.0f, 0.0f), Quaternion.Euler(0.0f, 0.0f, 90.0f));
                    break;
                case 2:
                    Instantiate(shape[Random.Range(0, 3)], new Vector3(-6.0f, 0.35f, 0.0f), Quaternion.Euler(0.0f, 0.0f, 180.0f));
                    break;
                case 3:
                    Instantiate(shape[Random.Range(0, 3)], new Vector3(-0.35f, -6.0f, 0.0f), Quaternion.Euler(0.0f, 0.0f, 270.0f));
                    break;
            }

            yield return new WaitForSeconds(timeOut);

        }
    }
}