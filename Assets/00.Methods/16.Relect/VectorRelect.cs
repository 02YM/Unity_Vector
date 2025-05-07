using UnityEngine;

// ���Լ��� ����ϽǶ� �����غ������� Ư�� ��ġ�� ����ų���� ������
// ���� ��ǥ�迡���� �������� Ư�� ������ ����Ű���� �Ǿ� �ִٴ� ���Դϴ�.

// ù��° �Ű������� ���� �ݻ纤�͸� ���ϰ��� �ϴ� ���Դϴ�.
// �ι�° �Ű������� ���� ���� ������ �����Ѵٰ� ���ø� �˴ϴ�.
// ���ذ��� �����ϴ� �����̱⿡ left, right�� ������ ��
// up, down�� ������ ���� �ȴٰ� ���ø� �˴ϴ�.


public class VectorRelect : MonoBehaviour
{

    public Transform target;
    public Vector3 targetVector;

    void Start()
    {
        targetVector = target.position;        
    }

    private void Update()
    {
        if (Input.anyKeyDown)
            target.position = Vector3.Reflect(target.position, Vector3.right);
    }
}
