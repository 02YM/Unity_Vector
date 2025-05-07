using UnityEngine;

// Vector3.OrthoNormalize�Լ��� (normal, tangent, binormal)
// Normal ���͸� �ް�, Tangent ���͸� �Ű������� ������
// Tangent ���͸� Normal ���Ϳ� ������ ���ͷ� �����մϴ�.
// �׸��� Normal, Tangent ���� ��� ���̰� 1�� �������ͷ� �����մϴ�.


// 1. normal�� ����ȭ
// 2. trangent�� normal�� ������ �ǵ��� ������ �� ����ȭ
// 3. binormal�� normal * tanget�� ���(����, ����ȭ�� ����)

// !! ����
// ��� ���̰�1
// ���� ����
// binormal = Vector3.Cross(normal, tangent)

public class VectorOrthoNormalize : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1�� ����(������ ���͸� �־ ) : �״�� ������ ���ͷ� ��µ�.
        //Vector3 up = new Vector3(0, 1, 0);
        //Vector3 right = new Vector3(1, 0, 0);
        //Vector3.OrthoNormalize(ref up, ref right);
        //print(up);
        //print(right);

        // 2�� ���� ( 45�� ������ �ǵ��� ������ ) : �����̰� ó����
        //Vector3 up = new Vector3(10, 10, 0) * 10;
        //Vector3 right = new Vector3(10, 0, 0);
        //Vector3.OrthoNormalize(ref up, ref right);
        //print(up);
        //print(right);

        // 3�� ���� ( �����ϰ� ó���ϰ�, ����� ���캽 ) : �����̰� ó����.
        Vector3 up = new Vector3(1, 1, 0);
        Vector3 right = new Vector3(-1, -1, 0);
        Vector3.OrthoNormalize(ref up, ref right);
        print(up);
        print(right);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
