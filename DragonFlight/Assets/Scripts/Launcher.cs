using UnityEngine;

public class Launcher : MonoBehaviour
{
    // 총알 프리펩을 가져오는 변수 추가
    public GameObject bullet;
    void Start()
    {
        //InvokeRepeating(함수 이름, 초기 지연 시간, 지연할 시간)으로 발사 구현
        //InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {

            // 총알 프리펩 생성, 발사 위치, 방향값은 주지 않는다.
            Instantiate(bullet, transform.position, Quaternion.identity);

            // 총알 발사 시, 사운드 재생
            SoundManager.instance.PlayBulletSound();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

    }
}
