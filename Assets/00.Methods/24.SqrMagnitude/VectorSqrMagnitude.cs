using UnityEngine;

public class VectorSqrMagnitude : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ������ ���̸� �Ѱ��ִ� �Լ��Դϴ�. (�������� ���̰� �ƴ� �� ����� ������ ���� ��)
        print(Vector3.SqrMagnitude(transform.position));
    }
}
