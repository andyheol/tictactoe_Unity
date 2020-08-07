using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{    
    // Stat is called before the first frame update
    void Start()
    {
    //    print("start start");
    }
    public void OnMouseDown()
    {
        SceneManager.LoadScene("what");
    }
    public void sibang()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
