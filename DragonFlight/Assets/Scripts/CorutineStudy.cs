using System.Collections;
using UnityEngine;

public class CorutineStudy : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()    
    {
        //Debug.Log("Coroutine!!");
        //yield return new WaitForSeconds(1); // 1초 대기, 코루틴 필수 문구
        //Debug.Log("1 second...");

        // while문을 통한 1초 대기 반복
        while(true)
        {
            Debug.Log("Coroutine!!");
            yield return new WaitForSeconds(1);
        }
    }
}
