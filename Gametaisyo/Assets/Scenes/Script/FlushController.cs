using UnityEngine;
using UnityEngine.UI;

public class FlushController : MonoBehaviour
{
    public Image Dimg;

    // Start is called before the first frame update
    public void Start()
    {
        Dimg.color = Color.clear;
        Debug.Log("starrrrrr ");
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("aho ");
        if (collider.gameObject.tag == "Enemy")
        {
            //*画面を赤塗りにする
            this.Dimg.color = new Color(0.5f, 0f, 0f, 0.5f);
            //Debug.Log("damage  ");

        }
    }

    void Update()
    {
        //時間が経過するにつれて徐々に透明にします。
        this.Dimg.color = Color.Lerp(this.Dimg.color, Color.clear, Time.deltaTime);

    }

    //private void OnCollisionEnter(Collision collider)
    //{
    //    if (collider.gameObject.tag == "Enemy")
    //    {
    //        //*画面を赤塗りにする
    //        this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
    //        Debug.Log("当たりーー");

    //    }
    //}

}