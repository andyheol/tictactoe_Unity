using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class newV : tog2 //MonoBehaviour
{
    public GameObject glast;
    public GameObject textt;
    public GameObject text2;

    bool ox = false;
    public int ieight = 9; // 남은 개수
    float delta = 0;
    int ihit = 0;
    public int[] arr = new int[9]; // 순서 저장
    public int[] last = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int t1 = 0, t2 = 0, t3 = 0, t4 = 0;
    public GameObject x;
    public GameObject o;
    public static int xpoint = 0;
    public static int opoint = 0;
    int irandnum = 0;
    bool k = false;
    int kb;
    int j = 0;
    public int icheckcopy;
    int okprocess;
    Vector2 worldpoint;
    RaycastHit2D hit;
    // public toggul a;
    bool bflag = false;
    public int temp;
    Vector3[] vk = new[]{
       new Vector3(-5.52f, 2.17f,0.0f),new Vector3(-2.59f, 2.17f, 0.0f), new Vector3(0.42f, 2.17f, 0.0f),
       new Vector3(-5.52f, -0.35f, 0.0f), new Vector3(-2.59f, -0.35f, 0.0f),new Vector3(0.42f, -0.27f, 0.0f),
       new Vector3(-5.52f, -2.95f, 0.0f),new Vector3(-2.59f, -2.95f, 0.0f),new Vector3(0.42f, -2.95f, 0.0f)
    };
    public int []sx = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public int sflag;
    public bool bs1 = false;
    public bool bs2;
 
    // Use this for initialization
    void Start()
    {
        //  print("newV start");
        icheckcopy = 0;
        glast.SetActive(false);

        for (int i = 0; i < 9; i++)
        {
            arr[i] = i;
            //  Debug.Log(arr[i]);
        }
        //   fkeyfromtoggul = GameObject.Find("secondtoggle").GetComponent<toggul>().key;
        //  if (fkeyfromtoggul == 1) sflag = 1;
        //  else sflag = 0;
        print("    " + arr[0] + arr[1] + arr[2] + arr[3] + arr[4] + arr[5] + arr[6] + arr[7] + arr[8]);
        temp = PlayerPrefs.GetInt("key");

        if (temp == 1) {
            sflag = 1;
            print("double key " + key);
        }
        else {
            sflag = 0;
            print("single key " + key);
        }
        print(" * * * ** * * ** * * ** * * *          ");
    } // Update is called once per frame

    void Update()
    {
        temp = PlayerPrefs.GetInt("key");
        // delta += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            if (ieight > 0)
            {
                switch (sflag)
                {
                    case 1: // double
                        worldpoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        hit = Physics2D.Raycast(worldpoint, Vector2.zero);

                        if (hit.collider != null) //Debug.Log("hit was " + hit.collider.name);
                        {
                            
                            int.TryParse(hit.collider.name, out kb);
                            // 0 , ieight 바icheckcopy = (ieight-1) ; icheckcopy < 9
                            kb = kb - 1;    // 0 ~8로 조정 <- 1~9
                            for (icheckcopy = (ieight) ; icheckcopy < 9; icheckcopy++)
                            {
                                if (sx[icheckcopy] == kb)
                                {
                                    bflag = true; // 중복
                                    print("_T.F ");
                                }
                            }
                            
                            Debug.Log("[1]hit__" + hit.collider.name);
                            for (int j = 0; j < ieight ; j++)
                                if(arr[j] == kb) irandnum = j;
                            
                           // print("[1]icheckcopy " + icheckcopy+ " ieight " + ieight);
                            if (  bflag == false)
                            {
                                sx[ieight - 1] = arr[irandnum];
                                x.transform.position = vk[arr[irandnum]];
                                Instantiate(x, x.transform);
                                last[arr[irandnum]] = 1;
                                test();
                                for (int i = irandnum; i < ieight - 1; i++) // 빈 곳 채우기
                                    arr[i] = arr[i + 1];

                                ieight--; // 8 > 7
                                print("[1]arr " + arr[0] + arr[1] + arr[2] + arr[3] + arr[4] + arr[5] + arr[6] + arr[7] + arr[8]);
                                print("[1]ieight " + ieight);
                                print("      ");
                                sflag = 2;
                            }
                            bflag = false;
                        } // hit.collider != null

                        break;
                    case 2: // 중복 검사를 하지 안음 !! 
                        //  print("s jesus");
                        worldpoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        hit = Physics2D.Raycast(worldpoint, Vector2.zero);
                        if (hit.collider != null)
                        {
                            //  print(" joo jesus");
                            int.TryParse(hit.collider.name, out kb);
                            kb = kb - 1; // 0 ~8로 조정
                            for (icheckcopy = (ieight ); icheckcopy < 9; icheckcopy++)
                            {
                                if (sx[icheckcopy] == kb)
                                {
                                    bflag = true; // 중복
                                    print("__T.F ");
                                }
                            }
                        //    Debug.Log("[2] hit name : " + hit.collider.name + " kb : "+kb);
                            for (int j = 0; j < ieight ; j++)
                                if (arr[j] == kb)
                                    irandnum = j;
                            if ( bflag == false)
                            {
                                sx[ieight - 1] = arr[irandnum];
                                //print("[2] arr[irandnum] " + arr[irandnum]);
                                o.transform.position = vk[arr[irandnum]];
                                Instantiate(o, o.transform);
                                last[arr[irandnum]] = -1;

                                test();
                                for (int i = irandnum; i < ieight - 1; i++) // 빈 곳 채우기
                                    arr[i] = arr[i + 1];
                                ieight--; // 8 > 7
                                          //print("____[2]" + arr[0] + arr[1] + arr[2] + arr[3] + arr[4] + arr[5] + arr[6] + arr[7] + arr[8]);
                                if (temp == 1) sflag = 1;
                                else sflag = 0; // 
                            }
                            print("      ");
                            bflag = false;
                        }
                        break;
                    default: break;
                }
            }
        } //input(mouse)

        if (sflag == 0 && ieight > 0) //single
        { 
            irandnum = Random.Range(0, ieight);
            sx[ieight - 1] = arr[irandnum];
            print("[input] irandnum " + irandnum + " arr[ ] " + arr[irandnum]);
            StartCoroutine("D_lay");

            x.transform.position = vk[arr[irandnum]];
            Instantiate(x, x.transform);
            last[arr[irandnum]] = 1; 
            test();
            sflag = 2; //
           //print("sflag  " + sflag);
            for (int i = irandnum; i < ieight - 1; i++) // 빈 곳 채우기
                arr[i] = arr[i + 1];
            print("       ");
           //print("[input] " + arr[0] + arr[1] + arr[2] + arr[3] + arr[4] + arr[5] + arr[6] + arr[7] + arr[8]);
           //print("[input] ieight" + ieight);
            ieight--; // 8 > 7
         }
        StartCoroutine("Ik");
    }// update

    void test()
    {
        if (ieight < 6)
        {
            switch (arr[irandnum])
            {
                case 0:
                    t1 = last[0] + last[1] + last[2]; t2 = last[0] + last[3] + last[6]; t3 = last[0] + last[4] + last[8];
                    if (t1 == 3 || t2 == 3 || t3 == 3) {  print("0"); xpoint += 1; ieight = -1; } // 게임 멈추고 점수 표시
                    else if (t1 == -3 || t2 == -3 || t3 == -3) {  print("0"); opoint += 1; ieight = -2; }
                    print("_0 t1:" + t1 + " t2:" + t2 + " t3:" + t3);
                    //  t1 = 0; t2 = 0; t3 = 0;
                    break;

                case 1:
                    t1 = last[0] + last[1] + last[2]; t2 = last[1] + last[4] + last[7];
                    print("_1 t1:" + t1 + " t2:" + t2);
                    if (t1 == 3 || t2 == 3) {  print("1"); xpoint += 1; ieight = -1; }
                    else if (t1 == -3 || t2 == -3) {  print("1"); opoint += 1; ieight = -2; }
                    //    t1 = 0; t2 = 0; 
                    break;

                case 2:
                    t1 = last[0] + last[1] + last[2]; t2 = last[2] + last[4] + last[6]; t3 = last[2] + last[5] + last[8];
                    if (t1 == 3 || t2 == 3 || t3 == 3) {  print("2"); xpoint += 1; ieight = -1; }
                    else if (t1 == -3 || t2 == -3 || t3 == -3) {  print("2"); opoint += 1; ieight = -2; }
                    print("_2 t1:" + t1 + " t2:" + t2 + " t3:" + t3);
                    //    t1 = 0; t2 = 0; t3 = 0;
                    break;

                case 3:
                    t1 = last[0] + last[3] + last[6]; t2 = last[3] + last[4] + last[5];
                    print("_3 t1:" + t1 + " t2:" + t2);
                    if (t1 == 3 || t2 == 3) {  print("3"); xpoint += 1; ieight = -1; }
                    else if (t1 == -3 || t2 == -3) {  print("3"); opoint += 1; ieight = -2; }
                    // t1 = 0; t2 = 0; 
                    break;
                case 4:
                    t1 = last[1] + last[4] + last[7]; t2 = last[3] + last[4] + last[5];
                    t3 = last[0] + last[4] + last[8]; t4 = last[2] + last[4] + last[6];
                    print("_4 t1:" + t1 + " t2:" + t2 + " t3:" + t3 + " t4:" + t4);
                    if (t1 == 3 || t2 == 3 || t3 == 3 || t4 == 3) {  print("4"); xpoint += 1; ieight = -1; }
                    else if (t1 == -3 || t2 == -3 || t3 == -3 || t4 == -3) {  print("4"); opoint += 1; ieight = -2; }
                    //  t1 = 0; t2 = 0; t3 = 0; t4 = 0;
                    break;
                case 5:
                    t1 = last[2] + last[5] + last[8]; t2 = last[3] + last[4] + last[5];
                    print("_5 t1:" + t1 + " t2:" + t2);
                    if (t1 == 3 || t2 == 3) {  print("5"); xpoint += 1; ieight = -1; }
                    else if (t1 == -3 || t2 == -3) {  print("5"); opoint += 1; ieight = -2; }
                    //   t1 = 0; t2 = 0;
                    break;

                case 6:
                    t1 = last[0] + last[3] + last[6]; t2 = last[2] + last[4] + last[6]; t3 = last[6] + last[7] + last[8];
                    if (t1 == 3 || t2 == 3 || t3 == 3) {  print("6"); xpoint += 1; ieight = -1; }
                    else if (t1 == -3 || t2 == -3 || t3 == -3) {  print("6"); opoint += 1; ieight = -2; }
                    print("_6 t1:" + t1 + " t2:" + t2 + " t3:" + t3);
                    //    t1 = 0; t2 = 0; t3 = 0;
                    break;

                case 7:
                    t1 = last[6] + last[7] + last[8]; t2 = last[1] + last[4] + last[7];
                    print("_7 t1:" + t1 + " t2:" + t2);
                    if (t1 == 3 || t2 == 3) {  print("7"); xpoint += 1; ieight = -1; }
                    else if (t1 == -3 || t2 == -3) {  print("7"); opoint += 1; ieight = -2; }
                    //    t1 = 0; t2 = 0;
                    break;

                case 8:
                    t1 = last[6] + last[7] + last[8]; t2 = last[0] + last[4] + last[8]; t3 = last[2] + last[5] + last[8];
                    if (t1 == 3 || t2 == 3 || t3 == 3) {  print("8"); xpoint += 1; ieight = -1; }
                    else if (t1 == -3 || t2 == -3 || t3 == -3) {  print("8"); opoint += 1; ieight = -2; }
                    print("_8--- t1:" + t1 + " t2:" + t2 + " t3:" + t3);
                    //  t1 = 0; t2 = 0; t3 = 0;
                    break;
            }
        }
    }
    IEnumerator D_lay()
    {
        yield return new WaitForSeconds(1.0f);
    }
    IEnumerator Ik()
    {
        if (ieight == -2)
        {
         //   print("sx " + sx[0] + sx[1] + sx[2] + sx[3] + sx[4] + sx[5] + sx[6] + sx[7] + sx[8]);
            yield return new WaitForSeconds(1.0f);
            glast.SetActive(true);
            textt.GetComponent<Text>().text = "x:" + xpoint + " " + "o:" + opoint;
            text2.GetComponent<Text>().text = "X win";
        }
        else if(ieight == -3)
        {
         //   print("sx " + sx[0] + sx[1] + sx[2] + sx[3] + sx[4] + sx[5] + sx[6] + sx[7] + sx[8]);
            yield return new WaitForSeconds(1.0f);
            glast.SetActive(true);
            textt.GetComponent<Text>().text = "x:" + xpoint + " " + "o:" + opoint;
            text2.GetComponent<Text>().text = "O win";
        }
        else if(ieight == 0)
        {
        //    print("sx " + sx[0] + sx[1] + sx[2] + sx[3] + sx[4] + sx[5] + sx[6] + sx[7] + sx[8]);
             yield return new WaitForSeconds(1.0f);
            glast.SetActive(true);
            textt.GetComponent<Text>().text = "x:" + xpoint + " " + "o:" + opoint;
            text2.GetComponent<Text>().text = "TIE";
        }
    }
}