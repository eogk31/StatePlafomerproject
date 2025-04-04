using UnityEngine;

public class BossHp : MonoBehaviour
{
    public int Bosshp = 10; // 기본 체력

    public GameObject explosion; // 폭발 효과
    private bool isDead = false; // 중복 제거 방지

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        Bosshp -= damage;
        Debug.Log("보스가 피격됨! 현재 체력: " + Bosshp);

        if (Bosshp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (isDead) return;

        isDead = true;
        Debug.Log("보스 사망!");
        Instantiate(explosion, transform.position, Quaternion.identity);
        SoundManager.instance.SoundDie();
        Destroy(gameObject); // 보스 삭제
    }
}
