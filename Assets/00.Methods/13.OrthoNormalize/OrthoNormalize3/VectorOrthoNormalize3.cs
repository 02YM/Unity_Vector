using UnityEngine;

// tangent : ���� ( tangent line�� � (�Ǵ� ����) ���� �� ������ ��� ���ϴ� ����)��

public class VectorOrthoNormalize3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1�� ���� ( ������ ���͸� �־ ) : �״�� ������ ���ͷ� ��µ�.
        //Vector3 normal = new Vector3(0, 1, 0);
        //Vector3 tangent = new Vector3(1, 0, 0);
        //Vector3 binormal = new Vector3(0, 0, 1);
        //Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
        //print(normal);
        //print(tangent);
        //print(binormal);

        // 
        // 2�� ���� (x��ǥ�� �ݴ�� ��. ) : binormal�� 1�� ������ �ݴ�� ��µ�
        //Vector3 normal = new Vector3(0, 1, 0);
        //Vector3 tangent = new Vector3(-1, 0, 0);
        //Vector3 binormal = new Vector3(0, 0, 0);
        //Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
        //print(normal);
        //print(tangent);
        //print(binormal);

        // 3�� ���� ( tangent�� �Է����� �ʾ����� normal�� binormal�� �ð�������� �������� �� ����(-1, 0, 0 )�� ��µ� )                   
        //Vector3 normal = new Vector3(0, 1, 0);
        //Vector3 tangent = new Vector3(0, 0, 0);
        //Vector3 binormal = new Vector3(0, 0, -1);
        //Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
        //print(normal);
        //print(tangent);
        //print(binormal);

        // 4�� ���� ( normal ���͸� ���������� ) (0,1,0), (-1, 0,0), (0,0,1) ����
        // ������ ���Ͱ� ��µ�.
        Vector3 normal = new Vector3(0, 1, 0);
        Vector3 tangent = new Vector3(0, 0, 0);
        Vector3 binormal = new Vector3(0, 0, 0);
        Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
        print(normal);
        print(tangent);
        print(binormal);
    }
}
