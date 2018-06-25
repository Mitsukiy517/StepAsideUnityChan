using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OutCamaraLineController : MonoBehaviour {

    //OutCameraLineのオブジェクト
    private GameObject outLine;

    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //unityちゃんとoutLineの距離
    private float difference;


    // Use this for initialization
    void Start () {

        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        //UnityちゃんとoutLineの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {

        //Unityちゃんの位置に合わせてoutLineの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);

    }

    void OnTriggerEnter(Collider other){

        //障害物に衝突した場合

        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag")
        {

            //画面外に出たオブジェクトを破棄
            Destroy(other.gameObject);

        }

    }


}
