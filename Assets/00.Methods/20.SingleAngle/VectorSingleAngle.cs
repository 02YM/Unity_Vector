using UnityEngine;
// https://suspiciously-useful.tistory.com/39
/*
 �Լ��� ���� ������ �������ڸ�,
�� ������ ������ 0~180 ������ ���ϰ� ������ 
���غ��ͷ� �־��ִ� ����° ���Ϳ� �������� ���� ���⼺�� ���� �ȴٸ�
180���� �Ѱܹް�,
���غ��ͷ� �־��ִ� ����° ���Ϳ� �������� ���� ���⼺�� ���� �ȴٸ�
-180���� �Ѱܹޱ� �����Դϴ�. 
 */

/*
public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
from �� to�� ������ ���� �� ����
axis�� ���� ����(������ up ����)
����� -180 ~ 180�� ������ ��

Vector3.Angle�� �׻� 0 ~ 180 ������ ���밪 ������ ��ȯ�մϴ�.
���� ������ ȸ�� ������ �߿��� ��찡 ���� ������ -180 ~ 180 (����) �̷� ������ �ʿ��մϴ�.

 */

/*
 ��ȯ�Ǵ� ������ ó�� �� ���� �Է��� �������� ó���� �� ù ��° ���Ϳ��� �� ��° ���ͷ��� 
 ȸ�� �����Դϴ�. �� �� ���ʹ� ���� ȸ�� ����� �����ϴµ�, �̴� ��鿡 �����ϴٴ� ���� 
 �ǹ��մϴ�. �̰��� ������ ���Ǵ� ȸ������ ù ��° �� �� ��° ������ ���������� �ǹ��մϴ� 
 "�޼� ��Ģ"�� ����Ͽ� �� ���� �Է� ���Ͱ� �־����� ȸ������ ������ �� �ֽ��ϴ�. 
 �� ��° �Ű����� axis�� ��꿡 ������ ��Ȳ�� ������ �����ϴ� ����� �����մϴ�. 
 �̷��� �ϸ� ����ڰ� �����ϴ� �� �� ��° ���Ͱ� ó�� �� �Է� ���Ϳ� ���� 
 ���ǵ� ȸ�� ��麸�� ���ų� ������ ���ο� ���� ����� ��ȣ�� ��Ī �̵��ϴ� 
 ����� �ֽ��ϴ�. ���� ���� ����� ��ȣ�� "from" �� "to" ���͸� �����ϴ� ������ 
 �� ��° "��" ������ ���⿡ ���� �޶����ϴ�. ����: ��ȯ�Ǵ� ������ �׻� -180������ 180�� �����Դϴ�.
 */

// Mathf.Sign �Լ��� 0�̻��̸� 1, 0�̸��̸� -1���� �����ϴ� �Լ��Դϴ�.
/*
         - �Լ��� ���� ���� Ȯ�� -
         1. ����� �� )
         from   = ( 0, 0, 1 )
         to     = ( 1, 0, 0 )
         axis   = ( 0, 1, 0 )

         1) ������ Ȱ���Ͽ� �� ���� ������ ������ ���մϴ�. �� ���ͻ����� ������ 
            ������ ����Ͽ� ���Ͽ��� ������ 0~180������ ������ �˴ϴ�.
         
         2) �� ���͸� �����Ͽ� �� ���Ϳ� ������ ���͸� ���մϴ�. (��������)
         3) �������Ϳ� ����° �Ű������� axis�� ���Ͽ� ���� ���⼺�� ������ ã���ϴ�. 
         
            
         public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
        {
            // �� ���� ������ ������ ���մϴ�. (0 ~ 180�� ������ ���� )
            float num = Angle(from, to);
            
            // �� ���͸� �����մϴ�. ( �����ϰ� �Ǹ� �� ���Ϳ� ������ ���Ͱ� ��������� �˴ϴ�. )
            float num2 = from.y * to.z - from.z * to.y;
            float num3 = from.z * to.x - from.x * to.z;
            float num4 = from.x * to.y - from.y * to.x;

            // Sign �Լ��� ����ϴ� ������ 1 �Ǵ� -1���� �����ϱ� �����Դϴ�.
            // �Ʒ��Ŀ��� axis������ ���� ���͸� ������ ������ ������ ���ϱ� ���ؼ� �׷����ϴ�.
            // ���� ���⼺�� ���´ٸ� ����� ���� ���̰�, �ٸ� ���⼺�� ���´ٸ� �� ������ 
            // ���� ������ ������ �� ���Դϴ�.
            float num5 = Mathf.Sign(axis.x * num2 + axis.y * num3 + axis.z * num4);
            return num * num5;
        }
 */

public class VectorSingleAngle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 from = Vector3.forward; // (0, 0, 1)
        Vector3 to = Vector3.left;      // (-1, 0, 0)
        Vector3 axis = Vector3.up;      // (0, 1, 0) ���� ȸ����

        float angle = Vector3.SignedAngle(from, to, axis);

        Debug.Log(angle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PositiveDirection()
    {
        float angle = Vector3.Angle(Vector3.forward, Vector3.right);
        print(angle);

        Vector3 crossVector = Vector3.Cross(Vector3.forward, Vector3.right);
        print(crossVector);

        // �� �׽�Ʈ ����� ���� ���⼺�� ���� �ִ��� üũ�ϴ� �ڵ��Դϴ�.
        float num5 = Mathf.Sign(0 * crossVector.x + 1 * crossVector.y + 0 * crossVector.z);

        // �� ������ üũ�ϰ� �ʹٸ� (0,-1,0) ���Ͱ��� �־� ������ üũ�ؾ� �մϴ�.
        //float num5 = Mathf.Sign(0 * crossVector.x + -1 * crossVector.y + 0 * crossVector.z);

        print(angle * num5);
    }

    void NegativeDirection()
    {
        // -- �Ʒ��� �ڵ�� �� ���͸� ������ �־� ���������� ������� üũ�ϱ� ���� �ڵ��Դϴ�.

        float angle = Vector3.Angle(Vector3.right, Vector3.forward);
        print(angle);

        Vector3 crossVector = Vector3.Cross(Vector3.right, Vector3.forward);
        print(crossVector);

        float num5 = Mathf.Sign(0 * crossVector.x + -1 * crossVector.y + 0 * crossVector.z);
        print(angle * num5);
    }
}
