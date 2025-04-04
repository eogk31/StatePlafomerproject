using UnityEngine;

public class BackGroundRepeat : MonoBehaviour
{
    // ��ũ���� �ӵ��� ����� ����
    public float scrollSpeed = 1.2f;

    // ���ȭ��(����)�� ���׸��� �����͸� �޾ƿ� ��ü ����
    public Material thismaterial;

    void Start()
    {
        // ��ü�� �����ɶ� ���� 1ȸ ȣ��Ǵ� �Լ�
        // ���� ��ü�� ������Ʈ���� ������ Renderer��� ������Ʈ�� Material ���� �޾ƿ���
        thismaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        // ���Ӱ� �������� Offset ��ü�� ����
        Vector2 newoffset = thismaterial.mainTextureOffset;

        // Y�κп� ���� y���� �ӵ��� ������ �����ؼ� ���ϱ�
        newoffset.Set(0, newoffset.y + (scrollSpeed * Time.deltaTime));

        // ���������� offSet ���� ����
        thismaterial.mainTextureOffset = newoffset;
    }
}
