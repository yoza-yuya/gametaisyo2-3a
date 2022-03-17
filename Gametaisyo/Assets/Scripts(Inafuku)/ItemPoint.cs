using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPoint : MonoBehaviour
{
    public int Blue = 0;
    public int sikaku = 0;
    public int tyoukaku = 0;
    public int syokkaku = 0;
    public int kyuukaku = 0;

    public bool mimi = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        
        if (collider.gameObject.tag == "Item(mikaku)")
        {
            Debug.Log("味覚のアイテム取れたよ");
            Blue = 2;
        }
    }
}
