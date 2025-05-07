using UnityEngine;

// Cross�� ���� ���� �Լ��Դϴ�.
// �� ���Ϳ� ������ ���͸� �Ѱ��ִ� �Լ��̸�
// ������ ������ �����ϴ�.
// Vector3(lhs.y * rhs.z - lhs.z * rhs.y,
//         lhs.z * rhs.x - lhs.x * rhs.z,
//         lhs.x * rhs.y - lhs.y * rhs.x)

public class Vector3Cross : MonoBehaviour
{

    public Transform up;
    public Transform right;
    public Transform result;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            result.position = Vector3.Cross(up.position, right.position);
    }
}
