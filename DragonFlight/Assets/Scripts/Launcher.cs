using UnityEngine;

public class Launcher : MonoBehaviour
{
    // �Ѿ� �������� �������� ���� �߰�
    public GameObject bullet;
    void Start()
    {
        //InvokeRepeating(�Լ� �̸�, �ʱ� ���� �ð�, ������ �ð�)���� �߻� ����
        //InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {

            // �Ѿ� ������ ����, �߻� ��ġ, ���Ⱚ�� ���� �ʴ´�.
            Instantiate(bullet, transform.position, Quaternion.identity);

            // �Ѿ� �߻� ��, ���� ���
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
