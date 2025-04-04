using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // 싱글톤 
    // 어디에서나 접근 가능하도록 static으로 자기 자신을 저장해서 싱글톤이라는 디자인 패턴 사용.
    public static UIManager instance;

    // 점수 표시 텍스트 저장 변수 작성
    public Text scoreText;

    // 점수 관리 변수
    public int score = 0;

    // 게임 시작 전 카운트 다운 추가
    public Text StartText;

    // 과제로 추가한 부분. 게임 카운트다운을 마치기 전까지 플레이어 비활성화.
    public GameObject player;

    // 과제로 추가한 부분. 게임 카운트다운을 마치기 전까지 적 생성 비활성화.
    public bool isGameStart = false;

    void Awake()
    {
        // 자신이 null인지 정적으로 체크
        if(instance == null)
        {
            // 맞다면 자기 자신을 저장하도록 조건 작성.
            instance = this;
        }
    }

    // 점수를 더해 텍스트에 반영해주는 인자를 가진 함수 작성
    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score: " + score;
    }



    void Start()
    {
        if (player != null)
        {
            player.SetActive(false); // **플레이어 비활성화**
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
                StartText.gameObject.SetActive(false); // 카운트다운 UI를 0이 되면 감추기
                player.SetActive(true);
                isGameStart = true;
                Debug.Log("게임 시작됨! isGameStart 값: " + isGameStart);
            }
        }
    }
}
