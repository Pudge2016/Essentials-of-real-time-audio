using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    private AudioSource audioSource;    
    private int collisionCount = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collisionCount++;
            if (collisionCount == 1)
            {
                audioSource.PlayOneShot(audioSource.clip, 0.5f);
            }
        }
    }
}
