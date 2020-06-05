using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RafHareketi : MonoBehaviour
{
    [SerializeField]
    public GameObject sinir;

    [SerializeField]
    public GameObject sinir2;
    float x = 0;
    void Update()
    {

    }

    public void Basildi()
    {
        float y = transform.position.y;
        float z = transform.position.z;

        if (x != sinir.transform.position.x)
        {
            x = sinir.transform.position.x;
            transform.position = new Vector3(x, y, z);
        }
        else
        {
            x = sinir2.transform.position.x;
            transform.position = new Vector3(x, y, z);
        }

    }
}
