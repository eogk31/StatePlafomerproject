using UnityEngine;

public class Enemy : MonoBehaviour
{
    // ������ �ӵ��� �����ϴ� �κ�
    public float moveSpeed = 1.3f;

    void Start()
    {
        
    }


    void Update()
    {
        // ������ �Ÿ��� ���
        float distanceY = moveSpeed * Time.deltaTime;

        // �������� ������ �Ʒ��̱⿡ ������ �����̰� ��� �ݿ�
        transform.Translate(0, -distanceY, 0);
    }

    // ȭ�� ������ ���� ī�޶󿡼� ������ ������ ȣ��Ǵ� �Լ� ����
    void OnBecameInvisible()
    {
        // �� ������Ʈ ������ ����
        Destroy(gameObject);
    }
}
