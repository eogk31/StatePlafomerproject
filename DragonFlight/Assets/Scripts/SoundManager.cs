using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // �̱������� �ڱ��ڽ��� ������
    public static SoundManager instance;

    // �ڽ��� ����� �ҽ� ��������
    // public�� ���� ���� ������ ��
    AudioSource audioSource;

    // �Ѿ� �߻�� ���� ���� �� ����Ǵ� �Ҹ� ����
    public AudioClip soundBullet;
    public AudioClip sounddie;

    void Awake()
    {
        if(SoundManager.instance == null)
        {
            SoundManager.instance = this;
        }
    }

    void Start()
    {
        // AudioSource �������� �κ�
        audioSource = GetComponent<AudioSource>();
    }

    // �÷��̾� ���ݰ� ���� ���� �Լ� ����
    public void PlayBulletSound()
    {
        audioSource.PlayOneShot(soundBullet);
    }

    public void SoundDie()
    {
        audioSource.PlayOneShot(sounddie);
    }
}
