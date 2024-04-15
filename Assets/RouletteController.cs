using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // ȸ���ӵ�
    bool slowingDown = false; // ���� ����

    void Start()
    {

    }

    void Update()
    {
        // ���콺 �� Ŭ���ϸ� �귿�� ������.
        if (Input.GetMouseButtonDown(2)) // ���콺 �� ��ư�� 2�� ��Ÿ���ϴ�.
        {
            this.rotSpeed = -10;
            slowingDown = false; // ���� ���� �ƴ��� ǥ��
        }

        // ���콺 ���� ��ư�� Ŭ���� ��� ������ �����.
        if (Input.GetMouseButtonDown(0))
        {
            slowingDown = true; // ���� ����
        }

        // ���콺 ������ ��ư�� Ŭ���� ��� �귿�� ������.
        if (Input.GetMouseButtonDown(1)) // ���콺 ������ ��ư�� 1�� ��Ÿ���ϴ�.
        {
            this.rotSpeed = -10;
            slowingDown = false; // ���� ���� �ƴ��� ǥ��
        }

        // ���� �� ��� ���� ����
        if (Input.GetMouseButtonUp(1))
        {
            slowingDown = true;
        }

        // �귿�� ���ӽ�Ų��.
        if (slowingDown)
        {
            this.rotSpeed *= 0.96f;
            // ȸ���ӵ��� ���� �� ���Ϸ� �������� ����
            if (Mathf.Abs(this.rotSpeed) < 0.01f)
            {
                this.rotSpeed = 0;
                slowingDown = false; // ���� ����
            }
        }

        // �귿�� ȸ����Ų��.
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
