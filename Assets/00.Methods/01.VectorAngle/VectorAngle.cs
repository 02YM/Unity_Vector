using UnityEngine;

// ui�� ����� ������ ��������� ���°��� ���ذ� ������ 
// �����Դϴ�.
// ui�� ����Ͽ��� ������ position ��ǥ�� ����ϸ� �ȵ˴ϴ�.
// ui�� position�� �������� ��ǥ�̸� ���� �ϴ��� ������ ��ũ����ǥ�Դϴ�.
// ���� ������ üũ�ϱ� ���ؼ� ��Ŀ�� �߾����� �����Ͽ�����
// localPosition�� Ȱ���Ͽ����ϴ�.

public class VectorAngle : MonoBehaviour
{
    public Transform Top;
    public Transform Bottom;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Vector3.Angle(Top.localPosition, Bottom.localPosition));
    }
}
