using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전속도
    bool slowingDown = false; // 감속 여부

    void Start()
    {

    }

    void Update()
    {
        // 마우스 휠 클릭하면 룰렛을 돌린다.
        if (Input.GetMouseButtonDown(2)) // 마우스 휠 버튼은 2를 나타냅니다.
        {
            this.rotSpeed = -10;
            slowingDown = false; // 감속 중이 아님을 표시
        }

        // 마우스 왼쪽 버튼을 클릭한 경우 서서히 멈춘다.
        if (Input.GetMouseButtonDown(0))
        {
            slowingDown = true; // 감속 시작
        }

        // 마우스 오른쪽 버튼을 클릭한 경우 룰렛을 돌린다.
        if (Input.GetMouseButtonDown(1)) // 마우스 오른쪽 버튼은 1을 나타냅니다.
        {
            this.rotSpeed = -10;
            slowingDown = false; // 감속 중이 아님을 표시
        }

        // 손을 뗀 경우 감속 시작
        if (Input.GetMouseButtonUp(1))
        {
            slowingDown = true;
        }

        // 룰렛을 감속시킨다.
        if (slowingDown)
        {
            this.rotSpeed *= 0.96f;
            // 회전속도가 일정 값 이하로 떨어지면 멈춤
            if (Mathf.Abs(this.rotSpeed) < 0.01f)
            {
                this.rotSpeed = 0;
                slowingDown = false; // 감속 종료
            }
        }

        // 룰렛을 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
