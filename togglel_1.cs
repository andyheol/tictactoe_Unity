﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toggle_1 : MonoBehaviour
{
    public Toggle toggle1; 
    //public Toggle toggle2;
    public bool layer = false;
    // public Text m_text;
    // public bool layer1 = false;
    //  public int a = 0;
    void Start()
    {
        toggle1.onValueChanged.AddListener(func);
    //    toggle2.onValueChanged.AddListener(funccc);
    }
   // Update is called once per frame
    void Update() // zero_double 값에 따라 토글 온오프 
    {
        toggle1.onValueChanged.AddListener(func);
    //    toggle2.onValueChanged.AddListener(funccc);
        /*
        a = toggle1.GetComponent<ZeroCross>().zero_double; //에러
        if (a == 0)
        {  toggle1.isOn = true; // double play
            //toggle2.isOn = false;
        }
        else if (a == 1)
        { toggle1.isOn = false;//toggle2.isOn = true;
        }
        */
    }
    public void func(bool value) // bool value
    {
        //check Box 눌리면 value가 트루임
        layer = value;
        if(value)
         print("toggle1");
        
        //m_text.text = toggle1.isOn;
        //if (toggle1.isOn)
        {
            // Debug.Log("t");
        }
        //else
        {
            //Debug.Log("f");
        }
    }
}
/*

*/
