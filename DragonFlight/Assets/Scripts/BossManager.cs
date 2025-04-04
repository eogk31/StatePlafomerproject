using Unity.VisualScripting;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    // 보스 몬스터 가지고 오는 부분
    public GameObject Boss;
    // 스폰 매니저 참조 추가 부분
    public SpawnManager SpawnManager;
    // 보스 생성 체크 부분
    public bool isBoss = false;



    void SpawnBoss()
    {
        if (!UIManager.instance.isGameStart || isBoss)
        {
            return;
        }

        // 보스의 생성
        // 600점 이상이 되면 보스 생성 및 SpawnManager를 비활성화
        if(UIManager.instance.score >= 300)
        {
            isBoss = true;
            GameObject spawnedBoss = Instantiate(Boss, new Vector3(0, transform.position.y, 0), Quaternion.identity);

            BossHp bossHpComponent = spawnedBoss.GetComponent<BossHp>();

            if (bossHpComponent != null)
            {
                bossHpComponent.Bosshp = 10; // 체력 설정
                Debug.Log("보스가 생성됨! 체력: " + bossHpComponent.Bosshp);
            }
            else
            {
                Debug.LogError("보스 프리팹에 BossHp 스크립트가 없음! 프리팹을 확인하세요.");
            }

            if (SpawnManager != null)
            {
                SpawnManager.CancelInvoke("SpawnEnemy");
            }

            Remove();
        }
    }

    void Remove()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach(GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
    }

    void Update()  // ← 여기에 추가!
    {
        SpawnBoss();  // 600점 이상이면 실행
    }
}
