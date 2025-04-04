using UnityEngine;

public class Player : MonoBehaviour
{
    // 움직이는 속도 정의
    // 사용자가 속도 변경 가능
    public float moveSpeed = 5.0f;
    void Start()
    {
        
    }
    void Update()
    {
        moveControll();
    }

    // 플레이어를 움직이게 하는 기본 함수 구현
    void moveControll()
    {
        // 지정 Axis를 통해 키의 방향 판단 및 속도와 프레임 판정을 곱해 이동량을 결정
        // 좌우로만 이동을 구현
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        // 이동량만큼 실제로 이동하도록 함수로 구현
        transform.Translate(distanceX, 0, 0);
    }
}
