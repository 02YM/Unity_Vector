using UnityEngine;

// Normalize�Լ��� ������ ���̸� ������, �� ���̰����� ��Ҹ� ������ 
// ���̸� 1�� �����ϴ� �Լ��Դϴ�.
// ���ӳ������� Ư�� ������ ���ϱ� ���� ���͸� ���Ҷ� Normalize�Լ��� ����ϰų�
// normalized �Ӽ����� ���� ����ϰ� �˴ϴ�.
// ���̸� 1�� ���ͷ� ���ϴ� ������ ����  * ���ǵ带 ������ �ش� ������ ����Ű�� ���͸� 
// 1�� ���ϸ� �ش� �������� �־��� ���ǵ常ŭ �Žð� �̵��� �� �ֱ� �����Դϴ�.

public class VectorNormalize : MonoBehaviour
{
    public Vector3 origin;
    public Vector3 transScale;
    public bool IsNormalize;

    void Start()
    {
        origin = new Vector3(3,4,0);
    }
    // ������ ���� ���ϱ�
    // ��Ʈ 3^2 + 4^2 + 0^2 = 5

    // �� ������ ����ȭ
    // 3/5, 4/5 , 0/5 = (0.6, 0.8, 0)

    // Update is called once per frame
    void Update()
    {        
        transScale = transform.localScale;
        if (IsNormalize)
        {
            transScale.Normalize();
            transform.localScale = transScale;
        }
        else
        transform.localScale = origin;
    }
}
