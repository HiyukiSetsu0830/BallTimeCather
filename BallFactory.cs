using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallFactory : MonoBehaviour
{

    [SerializeField] GameObject Ball;
    [SerializeField] GameObject StopBall;
    private Rigidbody rb;
    private Rigidbody rbStop;
    Coroutine coroutine;

    private float countDown = 5f;
    private float TimeLine = 0f;
    private bool firstshot;
    


    //Wave管理
    private bool boolAdmin = false;
    private bool boolAdmin2 = false;

    //wave1ボール管理
    private bool isBall = false;
    private bool isBall2 = true;
    private bool isBall3 = true;


    private bool ballShot = false;
    private bool ballShot2 = false;
    private bool ballShot3 = false;
    private bool ballShot4 = false;
    private bool ballShot5 = false;
    private bool ballShot6 = false;
    private bool ballShot7 = false;
    private bool ballShot8 = false;
    private bool ballShot9 = false;
    private bool ballShot10 = false;
    private bool ballShot11 = false;
    private bool ballShot12 = false;
    private bool ballShot13 = false;
    private bool ballShot14 = false;
    private bool ballShot15 = false;

    //wave2
    private bool ballShot16 = false;
    private bool ballShot17 = false;
    private bool ballShot18 = false;
    private bool ballShot19 = false;
    private bool ballShot20 = false;
    private bool ballShot21 = false;
    private bool ballShot22 = false;
    private bool ballShot23 = false;
    private bool ballShot24 = false;
    private bool ballShot25 = false;
    private bool ballShot26 = false;
    private bool ballShot27 = false;
    private bool ballShot28 = false;
    private bool ballShot29 = false;
    private bool ballShot30 = false;
    private bool ballShot31 = false;
    private bool ballShot32 = false;
    private bool ballShot33 = false;
    private bool ballShot34 = false;
    private bool ballShot35 = false;
    private bool ballShot36 = false;
    private bool ballShot37 = false;
    private bool ballShot38 = false;
    private bool ballShot39 = false;
    private bool ballShot40 = false;

    //Wave3
    private bool ballShot41 = false;
    private bool ballShot42 = false;
    private bool ballShot43 = false;
    private bool ballShot44 = false;
    private bool ballShot45 = false;
    private bool ballShot46 = false;
    private bool ballShot47 = false;
    private bool ballShot48 = false;
    private bool ballShot49 = false;
    private bool ballShot50 = false;
    private bool ballShot51 = false;
    private bool ballShot52 = false;
    private bool ballShot53 = false;
    private bool ballShot54 = false;
    private bool ballShot55 = false;
    private bool ballShot56 = false;
    private bool ballShot57 = false;
    private bool ballShot58 = false;
    private bool ballShot59 = false;
    private bool ballShot60 = false;
    private bool ballShot61 = false;
    private bool ballShot62 = false;
    private bool ballShot63 = false;
    private bool ballShot64 = false;
    private bool ballShot65 = false;
    private bool ballShot66 = false;
    private bool ballShot67 = false;
    private bool ballShot68 = false;
    private bool ballShot69 = false;
    private bool ballShot70 = false;
    private bool ballShot71 = false;
    private bool ballShot72 = false;
    private bool ballShot73 = false;
    private bool ballShot74 = false;
    private bool ballShot75 = false;
    private bool ballShot76 = false;
    private bool ballShot77 = false;
    private bool ballShot78 = false;
    private bool ballShot79 = false;
    private bool ballShot80 = false;



    // Start is called before the first frame update
    void Start() {

        rb = GetComponent<Rigidbody>();
        rbStop = StopBall.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

        

        TimeLine += Time.deltaTime;
       


        /**************************************************************
         *------------------------Wave1-------------------------------*
         **************************************************************/


        //1Wave
        if (!isBall) {

            if (TimeLine >= 6.5f && !ballShot) {

                ballShot = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 10f && !ballShot2) {

                ballShot2 = true;
                Instantiate(Ball, new Vector3(-3f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 11f && !ballShot3) {

                ballShot3 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 12f && !ballShot4) {

                ballShot4 = true;
                Instantiate(Ball, new Vector3(3f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 15f && !ballShot5) {
                ballShot5 = true;

                Instantiate(Ball, new Vector3(-5f, 22.0f, 14.6f), Quaternion.identity);
            }

            if (TimeLine >= 16.5f && !ballShot6) {

                ballShot6 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 18.0f && !ballShot7) {

                ballShot7 = true;
                Instantiate(Ball, new Vector3(-5f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 19.0f && !ballShot8) {

                ballShot8 = true;
                Instantiate(Ball, new Vector3(5f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 20.0f && !ballShot9) {

                ballShot9 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);
            }

            if (TimeLine >= 21.0f && !ballShot10) {

                ballShot10 = true;
                Instantiate(Ball, new Vector3(5f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 22.0f && !ballShot11) {

                ballShot11 = true;
                Instantiate(Ball, new Vector3(-2f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 23.0f && !ballShot12) {

                ballShot12 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 24.0f && !ballShot13) {

                ballShot13 = true;
                Instantiate(Ball, new Vector3(2.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 26.5f && !ballShot14) {

                ballShot14 = true;
                Instantiate(Ball, new Vector3(-5f, 22.0f, 14.6f), Quaternion.identity);
            }

            if (TimeLine >= 28.5f && !ballShot15) {

                ballShot15 = true;
                Instantiate(Ball, new Vector3(5f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 30.0f && !boolAdmin) {
                
                boolAdmin = true;
                isBall = true;
                isBall2 = false;
               
            }
        }

        //2セット
        if (!isBall2) {

            //16個目
            if (TimeLine >= 35.0f && !ballShot16) {

                ballShot16 = true;
                Instantiate(Ball, new Vector3(-5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //17個目
            if (TimeLine >= 36.0f && !ballShot17) {

                ballShot17 = true;
                Instantiate(Ball, new Vector3(5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //18個目
            if (TimeLine >= 37.0f && !ballShot18) {

                ballShot18 = true;
                Instantiate(Ball, new Vector3(-4f, 22.0f, 14.6f), Quaternion.identity);

            }

            //19個目
            if (TimeLine >= 38.0f && !ballShot19) {

                ballShot19 = true;
                Instantiate(Ball, new Vector3(4f, 22.0f, 14.6f), Quaternion.identity);

            }

            //20個目
            if (TimeLine >= 39.0f && !ballShot20) {
                ballShot20 = true;

                Instantiate(Ball, new Vector3(-3f, 22.0f, 14.6f), Quaternion.identity);
            }

            //21個目
            if (TimeLine >= 40.0f && !ballShot21) {

                ballShot21 = true;
                Instantiate(Ball, new Vector3(3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //22個目
            if (TimeLine >= 41.0f && !ballShot22) {

                ballShot22 = true;
                Instantiate(Ball, new Vector3(-2f, 22.0f, 14.6f), Quaternion.identity);

            }

            //23個目
            if (TimeLine >= 42.0f && !ballShot23) {

                ballShot23 = true;
                Instantiate(Ball, new Vector3(2f, 22.0f, 14.6f), Quaternion.identity);

            }

            //24個目
            if (TimeLine >= 43.0f && !ballShot24) {

                ballShot24 = true;
                Instantiate(Ball, new Vector3(-1f, 22.0f, 14.6f), Quaternion.identity);
            }

            //25個目
            if (TimeLine >= 44.0f && !ballShot25) {

                ballShot25 = true;
                Instantiate(Ball, new Vector3(1f, 22.0f, 14.6f), Quaternion.identity);

            }

            //26個目
            if (TimeLine >= 45.0f && !ballShot26) {

                ballShot26 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //27個目
            if (TimeLine >= 46.0f && !ballShot27) {

                ballShot27 = true;
                Instantiate(Ball, new Vector3(3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //28個目
            if (TimeLine >= 47.0f && !ballShot28) {

                ballShot28 = true;
                Instantiate(Ball, new Vector3(-3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //29個目
            if (TimeLine >= 48.0f && !ballShot29) {

                ballShot29 = true;
                Instantiate(Ball, new Vector3(5f, 22.0f, 14.6f), Quaternion.identity);
            }

            //30個目
            if (TimeLine >= 49.0f && !ballShot30) {

                ballShot30 = true;
                Instantiate(Ball, new Vector3(-5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //31個目
            if (TimeLine >= 50.0f && !ballShot31) {

                ballShot31 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //32個目
            if (TimeLine >= 51.0f && !ballShot32) {

                ballShot32 = true;
                Instantiate(Ball, new Vector3(3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //33個目
            if (TimeLine >= 52.0f && !ballShot33) {

                ballShot33 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //34個目
            if (TimeLine >= 53.0f && !ballShot34) {

                ballShot34 = true;
                Instantiate(Ball, new Vector3(-3f, 22.0f, 14.6f), Quaternion.identity);

            }
            //35個目
            if (TimeLine >= 54.0f && !ballShot35) {

                ballShot35 = true;
                Instantiate(Ball, new Vector3(5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //36個目
            if (TimeLine >= 55.0f && !ballShot36) {

                ballShot36 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //37個目
            if (TimeLine >= 56.0f && !ballShot37) {

                ballShot37 = true;
                Instantiate(Ball, new Vector3(-5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //38個
            if (TimeLine >= 57.0f && !ballShot38) {

                ballShot38 = true;
                Instantiate(Ball, new Vector3(-5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //39個目
            if (TimeLine >= 58.0f && !ballShot39) {

                ballShot39 = true;
                Instantiate(Ball, new Vector3(-3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //40個目
            if (TimeLine >= 59.0f && !ballShot40) {

                ballShot40 = true;
                Instantiate(Ball, new Vector3(3f, 22.0f, 14.6f), Quaternion.identity);

            }

            if (TimeLine >= 60.0f && !boolAdmin2) {

                boolAdmin2 = true;
                isBall2 = true;
                isBall3 = false;

            }

        }

        //3セット
        if (!isBall3) {

            //41個目
            if (TimeLine >= 65.0f && !ballShot41) {

                ballShot41 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //42個目
            if (TimeLine >= 65.5f && !ballShot42) {

                ballShot42 = true;
                Instantiate(Ball, new Vector3(1.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //43個目
            if (TimeLine >= 66.0f && !ballShot43) {

                ballShot43 = true;
                Instantiate(Ball, new Vector3(3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //44個目
            if (TimeLine >= 66.5f && !ballShot44) {

                ballShot44 = true;
                Instantiate(Ball, new Vector3(4.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //45個目
            if (TimeLine >= 67.0f && !ballShot45) {

                ballShot45 = true;
                Instantiate(Ball, new Vector3(6f, 22.0f, 14.6f), Quaternion.identity);

            }

            //46個目
            if (TimeLine >= 68.0f && !ballShot46) {

                ballShot46 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //47個目
            if (TimeLine >= 68.5f && !ballShot47) {

                ballShot47 = true;
                Instantiate(Ball, new Vector3(-1.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //48個目
            if (TimeLine >= 69.0f && !ballShot48) {

                ballShot48 = true;
                Instantiate(Ball, new Vector3(-3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //49個目
            if (TimeLine >= 70.0f && !ballShot49) {

                ballShot49 = true;
                Instantiate(Ball, new Vector3(-6f, 22.0f, 14.6f), Quaternion.identity);
                               
            }

            //50個目
            if (TimeLine >= 70.5f && !ballShot50) {

                ballShot50 = true;
                Instantiate(Ball, new Vector3(-4.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //51個目
            if (TimeLine >= 71.0f && !ballShot51) {

                ballShot51 = true;
                Instantiate(Ball, new Vector3(-3.0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //52個目
            if (TimeLine >= 71.5f && !ballShot52) {

                ballShot52 = true;
                Instantiate(Ball, new Vector3(-1.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //53個目
            if (TimeLine >= 72.0f && !ballShot53) {

                ballShot53 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //54個目
            if (TimeLine >= 72.5f && !ballShot54) {

                ballShot54 = true;
                Instantiate(Ball, new Vector3(1.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //55個目
            if (TimeLine >= 73.0f && !ballShot55) {

                ballShot55 = true;
                Instantiate(Ball, new Vector3(3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //56個目
            if (TimeLine >= 73.5f && !ballShot56) {

                ballShot56 = true;
                Instantiate(Ball, new Vector3(4.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //57個目
            if (TimeLine >= 74.0f && !ballShot57) {

                ballShot57 = true;
                Instantiate(Ball, new Vector3(6f, 22.0f, 14.6f), Quaternion.identity);

            }

            //58個目
            if (TimeLine >= 75.0f && !ballShot58) {

                ballShot58 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //59個目
            if (TimeLine >= 75.5f && !ballShot59) {

                ballShot59 = true;
                Instantiate(Ball, new Vector3(2f, 22.0f, 14.6f), Quaternion.identity);

            }

            //60個目
            if (TimeLine >= 76.0f && !ballShot60) {

                ballShot60 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //61個目
            if (TimeLine >= 77.0f && !ballShot61) {

                ballShot61 = true;
                Instantiate(Ball, new Vector3(-2f, 22.0f, 14.6f), Quaternion.identity);

            }

            //62個目
            if (TimeLine >= 77.5f && !ballShot62) {

                ballShot62 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //63個目
            if (TimeLine >= 78.0f && !ballShot63) {

                ballShot63 = true;
                Instantiate(Ball, new Vector3(-2f, 22.0f, 14.6f), Quaternion.identity);

            }

            //64個目
            if (TimeLine >= 78.5f && !ballShot64) {

                ballShot64 = true;
                Instantiate(Ball, new Vector3(-4f, 22.0f, 14.6f), Quaternion.identity);

            }

            //65個目
            if (TimeLine >= 80.0f && !ballShot65) {

                ballShot65 = true;
                Instantiate(Ball, new Vector3(4f, 22.0f, 14.6f), Quaternion.identity);

            }

            //66個目
            if (TimeLine >= 81.0f && !ballShot66) {

                ballShot66 = true;
                Instantiate(Ball, new Vector3(-2f, 22.0f, 14.6f), Quaternion.identity);

            }

            //67個目
            if (TimeLine >= 82.0f && !ballShot67) {

                ballShot67 = true;
                Instantiate(Ball, new Vector3(3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //68個目
            if (TimeLine >= 82.5f && !ballShot68) {

                ballShot68 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //69個目
            if (TimeLine >= 83.0f && !ballShot69) {

                ballShot69 = true;
                Instantiate(Ball, new Vector3(-3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //70個目
            if (TimeLine >= 84.0f && !ballShot70) {

                ballShot70 = true;
                Instantiate(Ball, new Vector3(2.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //71個目
            if (TimeLine >= 84.5f && !ballShot71) {

                ballShot71 = true;
                Instantiate(Ball, new Vector3(2.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //72個目
            if (TimeLine >= 85.5f && !ballShot72) {

                ballShot72 = true;
                Instantiate(Ball, new Vector3(-2.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //73個目
            if (TimeLine >= 86.0f && !ballShot73) {

                ballShot73 = true;
                Instantiate(Ball, new Vector3(-2.5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //74個目
            if (TimeLine >= 87.0f && !ballShot74) {

                ballShot74 = true;
                Instantiate(Ball, new Vector3(5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //75個目
            if (TimeLine >= 87.5f && !ballShot75) {

                ballShot75 = true;
                Instantiate(Ball, new Vector3(5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //76個目
            if (TimeLine >= 89.0f && !ballShot76) {

                ballShot76 = true;
                Instantiate(Ball, new Vector3(-5f, 22.0f, 14.6f), Quaternion.identity);

            }

            //77個目
            if (TimeLine >= 90.5f && !ballShot77) {

                ballShot77 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //78個目
            if (TimeLine >= 91.0f && !ballShot78) {

                ballShot78 = true;
                Instantiate(Ball, new Vector3(-3f, 22.0f, 14.6f), Quaternion.identity);

            }

            //79個目
            if (TimeLine >= 91.5f && !ballShot79) {

                ballShot79 = true;
                Instantiate(Ball, new Vector3(0f, 22.0f, 14.6f), Quaternion.identity);

            }

            //80個目
            if (TimeLine >= 92.0f && !ballShot80) {

                ballShot80 = true;
                Instantiate(Ball, new Vector3(3f, 22.0f, 14.6f), Quaternion.identity);

            }


        }
    }

    private IEnumerator DelayMethod(float waitTime, System.Action action) {

        yield return new WaitForSeconds(waitTime);
        action();

    }

}
