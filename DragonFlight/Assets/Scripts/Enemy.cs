using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 움직일 속도를 지정하는 부분
    public float moveSpeed = 1.3f;

    void Start()
    {
        
    }


    void Update()
    {
        // 움직일 거리를 계산
        float distanceY = moveSpeed * Time.deltaTime;

        // 움직임은 위에서 아래이기에 음수로 움직이게 계산 반영
        transform.Translate(0, -distanceY, 0);
    }

    // 화면 밖으로 나가 카메라에서 보이지 않으면 호출되는 함수 구현
    void OnBecameInvisible()
    {
        // 적 오브젝트 삭제를 구현
        Destroy(gameObject);
    }
}
