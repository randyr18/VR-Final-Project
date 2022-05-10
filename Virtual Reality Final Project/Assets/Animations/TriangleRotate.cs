using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(80f, 0f, 0f) * Time.deltaTime);
    }
}
