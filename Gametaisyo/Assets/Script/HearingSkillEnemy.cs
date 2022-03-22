using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearingSkillEnemy : MonoBehaviour
{
    Renderer ren;
    private float time = 0f;
    public int SkillTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<Renderer>();
        ren.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ren.enabled == true)
        {
            time += Time.deltaTime;
        }
        if(time >= SkillTime)
        {
            time = 0f;
            ren.enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Area")
        {
            ren.enabled = true;
        }
    }
}
