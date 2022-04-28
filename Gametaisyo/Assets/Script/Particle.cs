using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{

    // Start is called before the first frame update
    private ParticleSystem particle;
    // Update is called once per frame
    private void Start()
    {
        particle = this.GetComponent<ParticleSystem>();

        particle.Stop();
    }

    void Update()
    {
        void OnCollisionEnter(Collision collision)
        {
            if(Time.timeSinceLevelLoad > 10.0f & Time.timeSinceLevelLoad < 50.0f)
            {
                if(collision.gameObject.tag == "cube")
                {
                    particle.Play(); //パーティクルの再生
                }
            }
        }
    }
}
