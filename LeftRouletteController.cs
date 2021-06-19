using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    private GameObject left_roulette;
    bool rotFlag = false;

    void Start()
    {
        left_roulette = GameObject.Find("left_roulette");
    }

    //룰렛의 결과를 출력하는 함수
    void rouletteResult()
    {
        if (this.rotFlag == true)    //룰렛을 돌렸을 때만 결과 출력
        {
            float objAngle = left_roulette.transform.eulerAngles.z; //left_roulette의 z값의 각도
            string rouletteResult = "";

            if (objAngle > 30 && objAngle <= 90) rouletteResult += "대통";
            else if (objAngle > 90 && objAngle <= 150) rouletteResult += "매우나쁨";
            else if (objAngle > 150 && objAngle <= 210) rouletteResult += "보통";
            else if (objAngle > 211 && objAngle <= 270) rouletteResult += "조심";
            else if (objAngle > 271 && objAngle <= 330) rouletteResult += "좋음";
            else rouletteResult += "나쁨";

            Debug.Log("Left Roulette의 결과 : 운수" + rouletteResult);
            this.rotFlag = false;
        }
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            this.rotSpeed = 10;
            this.rotFlag = true;
        }

        this.rotSpeed *= 0.96f;

        transform.Rotate(0, 0, this.rotSpeed);

        //어느정도 속도가 감소되면 완전히 멈추도록 변경.
        if(this.rotSpeed < 0.1)
        {
            this.rotSpeed = 0;
            rouletteResult();
        }

    }


}
