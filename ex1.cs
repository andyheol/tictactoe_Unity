using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ex1 : MonoBehaviour
{
    public Toggle a;
    int aa = 0;
    // Start is called before the first frame update
    void Start()
    {
        a.onValueChanged.AddListener(zz);
        aa = PlayerPrefs.GetInt("key");
        a = GetComponent<Toggle>();
        if (aa == 0)
          a.isOn = true; //single
        else
            a.isOn = false; //double
    }
    void zz(bool value)
    {
        if (a.isOn == true) PlayerPrefs.SetInt("key", 0); // single
        else PlayerPrefs.SetInt("key", 1); // double
        SceneManager.LoadScene("what");
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
