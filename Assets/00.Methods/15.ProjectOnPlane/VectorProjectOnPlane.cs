using UnityEngine;
// ���͸� ��鿡 �����ϴµ� ���˴ϴ�.
// ���� ������ ���, �浹 ó��, ī�޶� �ý���
// ProjectOnPlane(vector, planeNormal)
// vector : ��鿡 ������ �����Դϴ�.
// planeNormal : �����Ϸ��� ����� ���� �����Դϴ�. ���� ���ʹ� ����� ���� �����Դϴ�.
// ���� = V - (V * N) * N

// �뵵.
// 1. �浹���
// 2. ī�޶� �ý���
// 3. ���� �� ���̴�

public class VectorProjectOnPlane : MonoBehaviour
{

    public Vector3 vector = new Vector3(3, 4, 5);
    public Vector3 planeNormal = new Vector3(0, 1, 0);
    // 3, 0, 5 ����� ���ȴϴ�.


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.ProjectOnPlane(vector, planeNormal));
    }
}
