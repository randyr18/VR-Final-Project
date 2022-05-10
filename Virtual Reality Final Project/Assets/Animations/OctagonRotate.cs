using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctagonRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(80f, 80f, 80f) * Time.deltaTime);
    }
}
