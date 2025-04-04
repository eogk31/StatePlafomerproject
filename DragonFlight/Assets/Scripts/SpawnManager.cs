using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // 몬스터 가지고 오는 부분
    public GameObject Enemy;

    // 과제 추가 부분. 새로 프리펩에 추가한 몬스터 추가.
    public GameObject Enemy2;
    public GameObject Enemy3;

    void Start()
    {
        // 함수를 SpawnEnemy로
        // 0.5초마다 몬스터를 1개씩 나오도록
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
    }

    void SpawnEnemy()
    {
        if (!UIManager.instance.isGameStart)
        {
            return;
        }
        // 적이 생성될 X좌표 랜덤 생성 부분
        float randomX = Random.Range(-2f, 2f);

        // 적의 생성
        // 과제 추가 부분. 적 2와 적 3을 추가. 200점 이상이면 적 2만, 400점 이상이면 적 3만 생성.
        if (UIManager.instance.score >= 200)
        {
            Instantiate(Enemy3, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }
        else if (UIManager.instance.score >= 100 && UIManager.instance.score <= 400)
        {
            Instantiate(Enemy2, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }
        else
        {
            Instantiate(Enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }

        // 적의 생성은 2차원 벡터도 유효!
        //Instantiate(Enemy, new Vector2(randomX, transform.position.y), Quaternion.identity);
    }

    void Update()
    {
        
    }
}
