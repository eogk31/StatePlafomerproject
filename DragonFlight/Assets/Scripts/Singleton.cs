using UnityEngine;

public class Singleton : MonoBehaviour
{
    // ����Ƽ���� �̱��� ��� ��, �ϳ��� �ν��Ͻ��� �����ϸ鼭 ��𼭵� ������ ����.
    public static Singleton Instance { get; private set; }

    // Start���� ���� �Լ� 1ȸ ���� �κ� Awake()
    // Ŭ������ 1ȸ�� �����ϸ鼭 �����ϵ���
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // ���� ����Ǿ �����ǰ��ϴ� �Լ�
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // �ߺ� ���� ����
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
