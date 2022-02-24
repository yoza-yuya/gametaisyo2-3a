using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    private float moveSpeed = 3.0f;
    private float chargeTime = 3.0f;
    private float timeCount;
    private float vecX;
    private float vecZ;

    void Update()
    {
        timeCount += Time.deltaTime;

        // 自動前進
        transform.position += transform.forward * Time.deltaTime * moveSpeed;

        // 指定時間の経過（条件）
        if (timeCount > chargeTime)
        {
            vecX = Random.Range(-1.5f, 1.0f);
            vecZ = Random.Range(-1.5f, 1.0f);
            // 進路をランダムに変更する
            Vector3 course = new Vector3(0, Random.Range(0, 360), 0);
            transform.localRotation = Quaternion.Euler(course);

            // タイムカウントを０に戻す
            timeCount = 0;
        }
    }
}
