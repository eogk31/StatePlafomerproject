using Unity.VisualScripting;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    // ���� ���� ������ ���� �κ�
    public GameObject Boss;
    // ���� �Ŵ��� ���� �߰� �κ�
    public SpawnManager SpawnManager;
    // ���� ���� üũ �κ�
    public bool isBoss = false;



    void SpawnBoss()
    {
        if (!UIManager.instance.isGameStart || isBoss)
        {
            return;
        }

        // ������ ����
        // 600�� �̻��� �Ǹ� ���� ���� �� SpawnManager�� ��Ȱ��ȭ
        if(UIManager.instance.score >= 300)
        {
            isBoss = true;
            GameObject spawnedBoss = Instantiate(Boss, new Vector3(0, transform.position.y, 0), Quaternion.identity);

            BossHp bossHpComponent = spawnedBoss.GetComponent<BossHp>();

            if (bossHpComponent != null)
            {
                bossHpComponent.Bosshp = 10; // ü�� ����
                Debug.Log("������ ������! ü��: " + bossHpComponent.Bosshp);
            }
            else
            {
                Debug.LogError("���� �����տ� BossHp ��ũ��Ʈ�� ����! �������� Ȯ���ϼ���.");
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

    void Update()  // �� ���⿡ �߰�!
    {
        SpawnBoss();  // 600�� �̻��̸� ����
    }
}
