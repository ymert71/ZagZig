using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float mvSpeed = 0.005f;
    void Start()
    {
        transform.transform.position = new Vector3(transform.position.x, transform.position.y,1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y-mvSpeed,0);
    }
}
