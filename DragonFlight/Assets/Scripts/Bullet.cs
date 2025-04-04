using UnityEngine;

public class Bullet : MonoBehaviour
{
    // ������ �ӵ��� �����ϴ� �κ�
    public float moveSpeed = 0.45f;

    // ������ ȿ�� �������� �κ�
    public GameObject explosion;

    // ������ �Ѿ� ��ü ������ �߰� �κ�.
    public int damage = 1;

    void Start()
    {
        // Singleton.cs�� �ۼ��� �Լ� �α� ��� �κ�.
        //Singleton.Instance.PrintMessage();
    }
    void Update()
    {
        // �Ѿ��� y�� �̵� ����
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    void OnBecameInvisible()
    {
        // �Ѿ��� ȭ�� ������ ������ ��ü ����
        // �ҹ��ڷ� ���۵Ǵ� gameObject�� �ڱ� �ڽ� = �Ѿ��� ����.
        Destroy(gameObject);
    }

    // 2D �浹 Ʈ���� �̺�Ʈ
    void OnTriggerEnter2D(Collider2D collision)
    {
       
        // �Ѿ˰� ���� �浹�ϴ� �̺�Ʈ ����
        // tag�� ���, CompareTag�� �ξ� ������
        if(collision.gameObject.tag == "Enemy")
        {
            // ���� ������ �����ϴ� ����Ʈ�� ����
            Instantiate(explosion, transform.position, Quaternion.identity);

            // ���� ������ ���� �� �״� ���� ���
            SoundManager.instance.SoundDie();

            // ���� ����Ʈ�� ���� ȹ��
            UIManager.instance.AddScore(10);

            // ���� ����
            // ���� �浹�� �߻��� ������Ʈ, �Ѿ��� �ڱ� �ڽ�
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        // ���� ��� �߰�
        if(collision.gameObject.tag == "Boss")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            SoundManager.instance.SoundDie();

            BossHp bossHp = collision.gameObject.GetComponent<BossHp>();

            if (bossHp != null)
            {
                Debug.Log("������ �Ѿ˿� ����! ������: " + damage);
                bossHp.TakeDamage(damage);
            }
            else
            {
                Debug.LogError("���� ��ü���� BossManager�� ã�� �� ����!");
            }
            Destroy(gameObject);
        }
    }
}
