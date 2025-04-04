using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // �̱��� 
    // ��𿡼��� ���� �����ϵ��� static���� �ڱ� �ڽ��� �����ؼ� �̱����̶�� ������ ���� ���.
    public static UIManager instance;

    // ���� ǥ�� �ؽ�Ʈ ���� ���� �ۼ�
    public Text scoreText;

    // ���� ���� ����
    public int score = 0;

    // ���� ���� �� ī��Ʈ �ٿ� �߰�
    public Text StartText;

    // ������ �߰��� �κ�. ���� ī��Ʈ�ٿ��� ��ġ�� ������ �÷��̾� ��Ȱ��ȭ.
    public GameObject player;

    // ������ �߰��� �κ�. ���� ī��Ʈ�ٿ��� ��ġ�� ������ �� ���� ��Ȱ��ȭ.
    public bool isGameStart = false;

    void Awake()
    {
        // �ڽ��� null���� �������� üũ
        if(instance == null)
        {
            // �´ٸ� �ڱ� �ڽ��� �����ϵ��� ���� �ۼ�.
            instance = this;
        }
    }

    // ������ ���� �ؽ�Ʈ�� �ݿ����ִ� ���ڸ� ���� �Լ� �ۼ�
    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score: " + score;
    }



    void Start()
    {
        if (player != null)
        {
            player.SetActive(false); // **�÷��̾� ��Ȱ��ȭ**
        }

        StartCoroutine(StartGame());
    }

    void Update()
    {

    }

    IEnumerator StartGame()
    {
        int i = 3;

        while (i > 0)
        {
            StartText.text = i.ToString();

            yield return new WaitForSeconds(1);

            i--;

            if (i == 0)
            {
                StartText.gameObject.SetActive(false); // ī��Ʈ�ٿ� UI�� 0�� �Ǹ� ���߱�
                player.SetActive(true);
                isGameStart = true;
                Debug.Log("���� ���۵�! isGameStart ��: " + isGameStart);
            }
        }
    }
}
