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

    //�귿�� ����� ����ϴ� �Լ�
    void rouletteResult()
    {
        if (this.rotFlag == true)    //�귿�� ������ ���� ��� ���
        {
            float objAngle = left_roulette.transform.eulerAngles.z; //left_roulette�� z���� ����
            string rouletteResult = "";

            if (objAngle > 30 && objAngle <= 90) rouletteResult += "����";
            else if (objAngle > 90 && objAngle <= 150) rouletteResult += "�ſ쳪��";
            else if (objAngle > 150 && objAngle <= 210) rouletteResult += "����";
            else if (objAngle > 211 && objAngle <= 270) rouletteResult += "����";
            else if (objAngle > 271 && objAngle <= 330) rouletteResult += "����";
            else rouletteResult += "����";

            Debug.Log("Left Roulette�� ��� : ���" + rouletteResult);
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

        //������� �ӵ��� ���ҵǸ� ������ ���ߵ��� ����.
        if(this.rotSpeed < 0.1)
        {
            this.rotSpeed = 0;
            rouletteResult();
        }

    }


}
