using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // 싱글톤으로 자기자신을 변수로
    public static SoundManager instance;

    // 자신의 오디오 소스 가져오기
    // public이 없어 직접 가져올 것
    AudioSource audioSource;

    // 총알 발사와 적의 죽음 시 재생되는 소리 변수
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
        // AudioSource 가져오기 부분
        audioSource = GetComponent<AudioSource>();
    }

    // 플레이어 공격과 적의 죽음 함수 구현
    public void PlayBulletSound()
    {
        audioSource.PlayOneShot(soundBullet);
    }

    public void SoundDie()
    {
        audioSource.PlayOneShot(sounddie);
    }
}
