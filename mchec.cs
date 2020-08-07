using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class mchec : MonoBehaviour
{
    int[] a = new int[9];
    private newV ascript;

    void Awake()
    {
       ascript=GetComponent<newV>();
    }
    // Use this for initialization
    void Start()
    {

    }
     // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            print(" ^_^ :"+ ascript.sx[0]+" "+ ascript.sx[1] + " " + ascript.sx[2] );
            print(" #_#  "+ ascript.sx[3]+" " + ascript.sx[4] + " " + ascript.sx[5]);
            print(" -_-*:"+ ascript.sx[6]+" " + ascript.sx[7] + " " + ascript.sx[8]);

        }
    }
}
