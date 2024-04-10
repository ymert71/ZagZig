using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [SerializeField] move move;
    [SerializeField] Text text;

    private int skor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        skor = move.getScore();
        print(skor);
        text.text = "" + skor.ToString();
    }
}
