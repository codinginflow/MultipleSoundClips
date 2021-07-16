using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletImpact : MonoBehaviour
{
    AudioSource impactSound;

    // Start is called before the first frame update
    void Start()
    {
        impactSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            impactSound.Play();
        }
    }
}
