using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float mvSpeed = 0.005f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x,transform.position.y-mvSpeed);
    }
}
