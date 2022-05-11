using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruct_Targets : MonoBehaviour
{
    // Start is called before the first frame 
    public float blastRadius = 2;
    public float explosionForce = 1000;
    public AudioClip hitSound;
    public GameObject particle;
    bool hasExploded = false;
    private Launch _launch;
    private void Start()
    {
        _launch = GameObject.Find("Arrow Spawn Point").GetComponent<Launch>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!hasExploded)
        {
            Explode();
            hasExploded = true;
            _launch.AddScore(10);
        }
    }
    
    public void Explode()
    {
        GameObject effect = Instantiate(particle, transform.position, transform.rotation);
        Collider[] nearbyObjects = Physics.OverlapSphere(transform.position, blastRadius);
        foreach (Collider nearbyObject in nearbyObjects)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, blastRadius);
            }
        }
        Destroy(gameObject);
        // Destroy effect after it does its job if I don't destory particle keeps playing
        Destroy(effect, 0.5f);
    }
}
