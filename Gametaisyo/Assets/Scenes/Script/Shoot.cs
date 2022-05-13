using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public float shotSpeed;
    private float shotInterval;

    private float timeBetweenShot = 3.00f;
    private float timer;
    

    void Update()
    {
        timer += Time.deltaTime;
        float tri = Input.GetAxis("Trigger");
        if (tri > 0 && timer > timeBetweenShot)
        {
                timer = 0.0f;

                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);

                //射撃されてから3秒後に銃弾のオブジェクトを破壊する.

                Destroy(bullet, 1.0f);
            }
    }
}
