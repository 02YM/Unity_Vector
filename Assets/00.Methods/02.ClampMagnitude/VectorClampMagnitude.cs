using UnityEngine;

//ClampMagnitude�Լ��� �ι�° �Ű������� �Ѱܹ��� ���̰� ��������
// ���� ������ ���̰� �� ũ�ٸ� ������ ���̰��� �������� ���ϰ�
// ������ �� ��Ҹ� ���������� ������ �ٽ� �ι�° �Ű������� �Ѱܹ��� ���̰��� 
// ���� ������ �� ����� �ִ���̸� �Ű������� �Ѱܹ��� ���̰����� �����ִ� �Լ��Դϴ�.
// Cube�� �������� (5, 1, 1)�Դϴ�.ClampMagnitude�� ����Ͽ�
// �������� ������ �����ϸ� �۰� ����� ������ �غ��� ���ҽ��ϴ�.

public class VectorClampMagnitude : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            transform.localScale = Vector3.ClampMagnitude(transform.localScale, 1);
        }
    }
}
