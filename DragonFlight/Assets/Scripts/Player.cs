using UnityEngine;

public class Player : MonoBehaviour
{
    // �����̴� �ӵ� ����
    // ����ڰ� �ӵ� ���� ����
    public float moveSpeed = 5.0f;
    void Start()
    {
        
    }
    void Update()
    {
        moveControll();
    }

    // �÷��̾ �����̰� �ϴ� �⺻ �Լ� ����
    void moveControll()
    {
        // ���� Axis�� ���� Ű�� ���� �Ǵ� �� �ӵ��� ������ ������ ���� �̵����� ����
        // �¿�θ� �̵��� ����
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        // �̵�����ŭ ������ �̵��ϵ��� �Լ��� ����
        transform.Translate(distanceX, 0, 0);
    }
}
