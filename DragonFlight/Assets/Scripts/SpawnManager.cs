using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // ���� ������ ���� �κ�
    public GameObject Enemy;

    // ���� �߰� �κ�. ���� �����鿡 �߰��� ���� �߰�.
    public GameObject Enemy2;
    public GameObject Enemy3;

    void Start()
    {
        // �Լ��� SpawnEnemy��
        // 0.5�ʸ��� ���͸� 1���� ��������
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
    }

    void SpawnEnemy()
    {
        if (!UIManager.instance.isGameStart)
        {
            return;
        }
        // ���� ������ X��ǥ ���� ���� �κ�
        float randomX = Random.Range(-2f, 2f);

        // ���� ����
        // ���� �߰� �κ�. �� 2�� �� 3�� �߰�. 200�� �̻��̸� �� 2��, 400�� �̻��̸� �� 3�� ����.
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

        // ���� ������ 2���� ���͵� ��ȿ!
        //Instantiate(Enemy, new Vector2(randomX, transform.position.y), Quaternion.identity);
    }

    void Update()
    {
        
    }
}
