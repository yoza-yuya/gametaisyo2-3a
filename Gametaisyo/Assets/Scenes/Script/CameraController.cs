using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraController : MonoBehaviour
{

    private GameObject player_position;   //プレイヤー情報格納用
    private Vector3 offset;      //相対距離取得用

    void Start()
    {

        //Playerの情報を取得
        this.player_position = GameObject.Find("Player");

        // MainCamera(自分自身)とplayerとの相対距離を求める
        offset = transform.position - player_position.transform.position;

    }

    void Update()
    {

        //新しいトランスフォームの値を代入する
        transform.position = player_position.transform.position + offset;

    }
}
