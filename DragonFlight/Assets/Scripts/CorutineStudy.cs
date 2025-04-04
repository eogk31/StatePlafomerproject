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
        //yield return new WaitForSeconds(1); // 1�� ���, �ڷ�ƾ �ʼ� ����
        //Debug.Log("1 second...");

        // while���� ���� 1�� ��� �ݺ�
        while(true)
        {
            Debug.Log("Coroutine!!");
            yield return new WaitForSeconds(1);
        }
    }
}
