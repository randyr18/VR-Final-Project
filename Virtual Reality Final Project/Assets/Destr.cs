using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
