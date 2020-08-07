using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tog2 : MonoBehaviour // double toggle 에 추가
{
    public Toggle b;
    public int key = 0;
    bool t = true;
    int ttemp;
    // Use this for initialization
    void Start()
    {
        //  a = GetComponent<Toggle>();
        b = GetComponent<Toggle>();//sec
        b.onValueChanged.AddListener(changeto);
        ttemp = PlayerPrefs.GetInt("key",0);
        if (ttemp == 1)
        {
            b.isOn = true; // double
        }
        else
        {
            b.isOn = false; // single
        }
    }
    public void changeto(bool value)
    {
         if (b.isOn) { key = 1; PlayerPrefs.SetInt("key", 1); } // double
         else if (b.isOn == false) { key = 0; PlayerPrefs.SetInt("key", 0); } //single
    // SceneManager.LoadScene("what");
    }        
    // Update is called once per frame
    void Update()
    {
     
    }
}
