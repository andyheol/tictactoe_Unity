using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class newV : MonoBehaviour
{
    public GameObject glast;
    public GameObject textt;
    public GameObject text2;

    bool ox = false;
    public int ieight = 9; // 남은 개수
    float delta = 0;
    int ihit = 0;
    int[] arr = new int[9]; // 순서 저장
    public int[] last = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int t1 = 0, t2 = 0, t3 = 0, t4 = 0;
    public GameObject x;
    public GameObject o;
    public static int xpoint = 0;
    public static int opoint = 0;
    int irandnum = 0;
    int s1 = -1;
    int s2 = 3;
    int s3 = 4;
    
    Vector3[] vk = new[]{
       new Vector3(-5.52f, 2.17f,0.0f),new Vector3(-2.59f, 2.17f, 0.0f), new Vector3(0.42f, 2.17f, 0.0f),
       new Vector3(-5.52f, -0.35f, 0.0f), new Vector3(-2.59f, -0.35f, 0.0f),new Vector3(0.42f, -0.27f, 0.0f),
       new Vector3(-5.52f, -2.95f, 0.0f),new Vector3(-2.59f, -2.95f, 0.0f),new Vector3(0.42f, -2.95f, 0.0f)
    };
    // Use this for initialization
    void Start()
    {
        glast.SetActive(false);
        //xpoint = PlayerPrefs.GetInt("x");
        //opoint = PlayerPrefs.GetInt("y");
        for (int i = 0; i < 9; i++)
        {
            arr[i] = i;
            Debug.Log(arr[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if (delta > 1.0f && ieight > 0)
        {
            delta = 0;
            irandnum = Random.Range(0, ieight);

            // test 순서대로 9개 다 뽑히는지
            print(" chosen " + irandnum + "   " + arr[irandnum]);
            ieight--; // 8 > 7
            switch (ox)
            {
                case false:
                    x.transform.position = vk[arr[irandnum]];
                    Instantiate(x, x.transform);
                    ox = true;
                    last[arr[irandnum]] = 1;
                    break;
                case true:
                    o.transform.position = vk[arr[irandnum]];
                    Instantiate(o, o.transform);
                    ox = false;
                    last[arr[irandnum]] = -1;
                    break;
            }
          
             if( ieight <5 )
            {
                switch (arr[irandnum])
                {
                    case 0:
                        t1 = last[0] + last[1] + last[2];
                        t2 = last[0] + last[3] + last[6];
                        t3 = last[0] + last[4] + last[8];
                        if (t1 == 3 || t2 == 3 || t3 == 3) { print("0"); xpoint += 1; ieight = -1; } // 게임 멈추고 점수 표시
                        else if (t1 == -3 || t2 == -3 || t3 == -3) { print("0"); opoint += 1; ieight = -2; }
                        print("0 t1:" + t1 + " t2:" + t2 + " t3:" + t3 );
                        t1 = 0; t2 = 0; t3 = 0;
                        break;
                    
                    case 1:
                        t1 = last[0] + last[1] + last[2];
                        t2 = last[1] + last[4] + last[7];
                        print("1 t1:" + t1 + " t2:" + t2);
                        if (t1 == 3 || t2 == 3) { print("1"); xpoint += 1; ieight = -1; }
                        else if (t1 == -3 || t2 == -3) { print("1"); opoint += 1; ieight = -1; }
                        t1 = 0; t2 = 0; 
                        break;
                    case 2:
                        t1 = last[0] + last[1] + last[2];
                        t2 = last[2] + last[4] + last[6];
                        t3 = last[2] + last[5] + last[8];
                        if (t1 == 3 || t2 == 3 || t3 == 3) { print("2"); xpoint += 1; ieight = -1; }
                        else if (t1 == -3 || t2 == -3 || t3 == -3) { print("2"); opoint += 1; ieight = -2; }
                        print("2 t1:" + t1 + " t2:" + t2 + " t3:" + t3);
                        t1 = 0; t2 = 0; t3 = 0;
                        break;
                    case 3:
                        t1 = last[0] + last[3] + last[6];
                        t2 = last[3] + last[4] + last[5];
                        print("3 t1:" + t1 + " t2:" + t2 );
                        if (t1 == 3 || t2 == 3) { print("3"); xpoint += 1; ieight = -1; }
                        else if (t1 == -3 || t2 == -3) { print("3"); opoint += 1; ieight = -2; }
                        t1 = 0; t2 = 0; 
                        break;
                    case 4:
                        t1 = last[1] + last[4] + last[7];
                        t2 = last[3] + last[4] + last[5];
                        t3 = last[0] + last[4] + last[8];
                        t4 = last[2] + last[4] + last[6];
                        print("4 t1:" + t1 + " t2:" + t2 + " t3:" + t3 + " t4:" + t4);
                        if (t1 == 3 || t2 == 3 || t3 == 3 || t4 == 3) { print("4"); xpoint += 1; ieight = -1; }
                        else if (t1 == -3 || t2 == -3 || t3 == -3 || t4 == -3) { print("4"); opoint += 1; ieight = -2; }
                        t1 = 0; t2 = 0; t3 = 0; t4 = 0;
                        break;
                    case 5:
                        t1 = last[2] + last[5] + last[8];
                        t2 = last[3] + last[4] + last[5];
                        print("5 t1:" + t1 + " t2:" + t2 );
                        if (t1 == 3 || t2 == 3) { print("5"); xpoint += 1; ieight = -1; }
                        else if (t1 == -3 || t2 == -3) { print("5"); opoint += 1; ieight = -2; }
                        t1 = 0; t2 = 0;
                        break;

                    case 6:
                        t1 = last[0] + last[3] + last[6];
                        t2 = last[2] + last[4] + last[6];
                        t3 = last[6] + last[7] + last[8];
                        if (t1 == 3 || t2 == 3 || t3 == 3) { print("6"); xpoint += 1; ieight = -1; }
                        else if (t1 == -3 || t2 == -3 || t3 == -3) { print("6"); opoint += 1; ieight = -2; }
                        print("6 t1:" + t1 + " t2:" + t2 + " t3:" + t3);
                        t1 = 0; t2 = 0; t3 = 0;
                        break;

                    
                    case 7:
                        t1 = last[6] + last[7] + last[8];
                        t2 = last[1] + last[4] + last[7];
                        print("7 t1:" + t1 + " t2:" + t2 );
                        if (t1 == 3 || t2 == 3) { print("7"); xpoint += 1; ieight = -1; }
                        else if (t1 == -3 || t2 == -3) { print("7"); opoint += 1; ieight = -2; }
                        t1 = 0; t2 = 0;
                        break;
                    case 8:
                        t1 = last[6] + last[7] + last[8];
                        t2 = last[0] + last[4] + last[8];
                        t3 = last[2] + last[5] + last[8];
                        if (t1 == 3 || t2 == 3 || t3 == 3) { print("8"); xpoint += 1; ieight = -1; }
                        else if (t1 == -3 || t2 == -3 || t3 == -3) { print("8"); opoint += 1; ieight = -2; }
                        print("8 t1:" + t1 + " t2:" + t2 + " t3:" + t3);
                        t1 = 0; t2 = 0; t3 = 0;
                        break;

                }
            }//if( ieight <5 )

            //  xxx.transform.position = vk[arr[irandnum]];
            for (int i = irandnum; i < 8; i++) // 빈 곳 채우기
                arr[i] = arr[i + 1]; // ieight = 8

            // 판정

        }//if (delta > 2.0f && ieight > 0)
        else if (ieight == 0) // 동점 처리
        {
            ieight = -3;
        }
        StartCoroutine("Ik");
    }// update
   
    IEnumerator Ik()
    {
        if (ieight == -1)
        {
            yield return new WaitForSeconds(2.0f);

            glast.SetActive(true);
            print("ieight" + ieight);
            //  PlayerPrefs.SetInt("x", xpoint);
            //  PlayerPrefs.SetInt("y", opoint);
            textt.GetComponent<Text>().text = "x:" + xpoint + " " + "o:" + opoint;
            text2.GetComponent<Text>().text = "X win";

            // print("xpoint: " + xpoint + " opoint: " + opoint);
            ieight = -4; // default
          //  SceneManager.LoadScene("what");
        }
        else if(ieight == -2)
        {
            yield return new WaitForSeconds(2.0f);

            glast.SetActive(true);
            textt.GetComponent<Text>().text = "x:" + xpoint + " " + "o:" + opoint;
            text2.GetComponent<Text>().text = "O win";
            ieight = -4;
        }
        else if(ieight == -3) // 동점 처ㄹ
        {
            yield return new WaitForSeconds(2.0f);
            glast.SetActive(true);
            textt.GetComponent<Text>().text = "x:" + xpoint + " " + "o:" + opoint;
            text2.GetComponent<Text>().text = "TIE";
            ieight = -4;
        }
         yield return 0;
    }
}