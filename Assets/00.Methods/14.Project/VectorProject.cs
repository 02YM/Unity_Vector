using UnityEngine;

// ���� ���Ͷ�
// ���� A�� ����B�� �������� ���� ��Ų �����Դϴ�.
// A�� ���⼺�� �״�� ����������, B�� ������ ���� ������ �����Դϴ�.
// 1�� ���� ���
// A�� B�� ������ ���մϴ�. (3 * 1) + (4 * 0) = 3

// 2�� �ڱ� ���� ���
// B�� �ڱ� ������ ���մϴ�. (1 * 1) + (0 * 0) = 1

// 3�� ���� ���
// 1��/2�� * B = 3,0

// ���� ������ ���� ���� ����
// { (A * B) / (B * B) } * B = 

public class VectorProject : MonoBehaviour
{

    // A : ������ ����
    // B : �����Ϸ��� ���� ����
    public Vector3 A = new Vector3(3, 4, 0);
    public Vector3 B = new Vector3(1, 0, 0);

    void Start()
    {
        
    }

    
    void Update()
    {
        // A�� B�� ����
        Debug.Log(Vector3.Project(A, B));
    }
}
