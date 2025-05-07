using UnityEngine;

// Vector3.LerpUnclamped(Vector3 a, Vector3 b, float t)
// a : ���� ����
// b : �� ����
// t : ���� ���� (0 -> a, 1 -> b, 0.5 -> �߰�, �ʰ�/�̸� ����)


public class VectorLerpUnclamped : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float t = 1.5f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // t�� 1.5�� pointB�� �Ѿ �̵��մϴ�.
        Vector3 pos = Vector3.LerpUnclamped(pointA.position, pointB.position, t);
        transform.position = pos;
    }
}
