using UnityEngine;

public class BackGroundRepeat : MonoBehaviour
{
    // 스크롤할 속도를 상수로 지정
    public float scrollSpeed = 1.2f;

    // 배경화면(쿼드)의 머테리얼 데이터를 받아올 객체 선언
    public Material thismaterial;

    void Start()
    {
        // 객체가 생성될때 최초 1회 호출되는 함수
        // 현재 객체의 컴포넌트들을 참조해 Renderer라는 컴포넌트의 Material 정보 받아오기
        thismaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // 새롭게 지정해줄 Offset 객체를 선언
        Vector2 newoffset = thismaterial.mainTextureOffset;

        // Y부분에 현재 y값에 속도에 프레임 보정해서 더하기
        newoffset.Set(0, newoffset.y + (scrollSpeed * Time.deltaTime));

        // 최종적으로 offSet 값을 지정
        thismaterial.mainTextureOffset = newoffset;
    }
}
