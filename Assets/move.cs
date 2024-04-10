using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    public float mvSpeed = 0.005f;
    public bool mDirRight = true;
    // Start is called before the first frame update
    [SerializeField] Camera cam;

    [SerializeField] LayerMask layerMask;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   
        
        if(mDirRight == true)
        transform.position = new Vector2(transform.position.x+mvSpeed,transform.position.y);
        else if(mDirRight== false)
        transform.position = new Vector2(transform.position.x-mvSpeed, transform.position.y);
        if(Input.GetKeyDown(KeyCode.Space)){
            mDirRight = !mDirRight;
        }
        /*
        Vector3 screenpos = cam.WorldToScreenPoint(transform.position);
        if(screenpos.x < 0 || screenpos.x > cam.pixelWidth)
            transform.position = new Vector2(0,transform.position.y);
        */
    }
    void FixedUpdate()
    {   
        
        if (!Physics2D.OverlapCircle(transform.position, transform.localScale.x-0.7f,layerMask)){
            //print("YES");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
