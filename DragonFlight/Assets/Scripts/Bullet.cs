using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 움직일 속도를 지정하는 부분
    public float moveSpeed = 0.45f;

    // 프리펩 효과 가져오는 부분
    public GameObject explosion;

    // 과제로 총알 자체 데미지 추가 부분.
    public int damage = 1;

    void Start()
    {
        // Singleton.cs에 작성한 함수 로그 출력 부분.
        //Singleton.Instance.PrintMessage();
    }
    void Update()
    {
        // 총알의 y축 이동 구현
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    void OnBecameInvisible()
    {
        // 총알이 화면 밖으로 나가면 객체 삭제
        // 소문자로 시작되는 gameObject는 자기 자신 = 총알을 뜻함.
        Destroy(gameObject);
    }

    // 2D 충돌 트리거 이벤트
    void OnTriggerEnter2D(Collider2D collision)
    {
       
        // 총알과 적이 충돌하는 이벤트 구현
        // tag의 경우, CompareTag가 훨씬 안정적
        if(collision.gameObject.tag == "Enemy")
        {
            // 적과 닿으면 폭발하는 이펙트를 정리
            Instantiate(explosion, transform.position, Quaternion.identity);

            // 적과 닿으면 폭발 후 죽는 사운드 재생
            SoundManager.instance.SoundDie();

            // 적을 쓰러트려 점수 획득
            UIManager.instance.AddScore(10);

            // 적을 삭제
            // 적은 충돌이 발생한 오브젝트, 총알은 자기 자신
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        // 보스 사냥 추가
        if(collision.gameObject.tag == "Boss")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            SoundManager.instance.SoundDie();

            BossHp bossHp = collision.gameObject.GetComponent<BossHp>();

            if (bossHp != null)
            {
                Debug.Log("보스가 총알에 맞음! 데미지: " + damage);
                bossHp.TakeDamage(damage);
            }
            else
            {
                Debug.LogError("보스 객체에서 BossManager를 찾을 수 없음!");
            }
            Destroy(gameObject);
        }
    }
}
