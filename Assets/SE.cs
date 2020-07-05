using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour {

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    void Update () {
            
        }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "ZimenTag")
        {
            audioSource.PlayOneShot(sound1);

        }
    }

    }
	