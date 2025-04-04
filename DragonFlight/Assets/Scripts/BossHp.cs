using UnityEngine;

public class BossHp : MonoBehaviour
{
    public int Bosshp = 10; // �⺻ ü��

    public GameObject explosion; // ���� ȿ��
    private bool isDead = false; // �ߺ� ���� ����

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        Bosshp -= damage;
        Debug.Log("������ �ǰݵ�! ���� ü��: " + Bosshp);

        if (Bosshp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (isDead) return;

        isDead = true;
        Debug.Log("���� ���!");
        Instantiate(explosion, transform.position, Quaternion.identity);
        SoundManager.instance.SoundDie();
        Destroy(gameObject); // ���� ����
    }
}
