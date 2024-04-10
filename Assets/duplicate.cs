using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class duplicate : MonoBehaviour
{
    public GameObject rootObj;
    public GameObject circle;
    private int counter = 1;
    private int childCount = 0;

    [SerializeField] Transform tr;
    private float increment = 1.4f;
    private float dir = 1.4f;

    
    //private List<Transform> children;

    private float xAxis = 0;
    // Start is called before the first frame update
    void Start()
    {
        xAxis = rootObj.transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(counter % 5 == 0){
            
            if(counter % 3 == 0){
                dir = Random.Range(0,2);
                if(dir == 0){
                    dir = -1.4f;
                }
                if(dir == 1){
                    dir = 1.4f;
                }
            }
            if(xAxis > 9.7f){
                dir = -1.4f;
            }
            else if(xAxis < -9.7f){
                dir = 1.4f;
            }
            if(rootObj.transform.position.y + increment < 40){
                GameObject gm = Instantiate(rootObj, new Vector3(xAxis+dir, rootObj.transform.position.y + increment, 0), rootObj.transform.rotation,tr);
                childCount++;
                //print(childCount);
                gm.layer = rootObj.layer;
                gm.name = "sqr" + counter;
                increment += 1.4f;
                xAxis = xAxis + dir;
                print(xAxis);

                if(childCount > 80){
                    Transform tmp;
                    if(tmp = tr.GetChild(childCount - 80)){
                        Destroy(tmp.gameObject);
                        childCount--;
                    }
                }
            }
            
        }
        counter++;
            
       
    }
}
