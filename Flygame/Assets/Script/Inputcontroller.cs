using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inputcontroller : MonoBehaviour
{
    /*
     * ����� �Է��Ѱ��ϴ� Ŭ���� (��ũ��Ʈ)
     * 
     */

    private void Update()
    {
        /*
         * ������Է�,
         * ��ü���� ���� ����
         * UI ��� ��ũ��Ʈ
         */

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //�������� �̵�
            Logics.instance.PLAYER_DIR = Logics.PlayerDirection.LEFT;

        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Logics.instance.PLAYER_DIR = Logics.PlayerDirection.NONE;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //���������� �̵�
            Logics.instance.PLAYER_DIR = Logics.PlayerDirection.RIGHT;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Logics.instance.PLAYER_DIR = Logics.PlayerDirection.NONE;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //������ �Ұ�.
            Logics.instance.Fire();
        }
    }

    private void LateUpdate()
    {
        /*
         * 
         */

    }
}

