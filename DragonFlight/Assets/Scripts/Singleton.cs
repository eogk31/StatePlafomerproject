using UnityEngine;

public class Singleton : MonoBehaviour
{
    // 유니티에서 싱글톤 사용 시, 하나의 인스턴스만 유지하면서 어디서든 접근이 가능.
    public static Singleton Instance { get; private set; }

    // Start보다 빠른 함수 1회 실행 부분 Awake()
    // 클래스를 1회만 생성하면서 유지하도록
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // 씬이 변경되어도 유지되게하는 함수
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 중복 생성 방지
            Destroy(gameObject);
        }
    }

    public void PrintMessage()
    {
        Debug.Log("Singleton!!");
    }

    void Update()
    {
        
    }
}
