using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruct_Targets : MonoBehaviour
{
    // Start is called before the first frame 
    public AudioClip hitSound;
    void Start()
    {
        //GetComponent<AudioSource>().playOnAwake = false;
        //GetComponent<AudioSource>().clip = hitSound;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //GetComponent<AudioSource>().Play();
        Destroy(gameObject);
        
    }
}
