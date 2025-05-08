using UnityEngine;
// https://suspiciously-useful.tistory.com/39
/*
 함수에 대해 간단히 정리하자면,
두 벡터의 각도를 0~180 단위로 구하고 싶은데 
기준벡터로 넣어주는 세번째 벡터와 비교했을때 같은 방향성을 같게 된다면
180도를 넘겨받고,
기준벡터로 넣어주는 세번째 벡터와 비교했을때 같은 방향성을 같게 된다면
-180도를 넘겨받기 위함입니다. 
 */

/*
public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
from 과 to는 각도를 구할 두 벡터
axis는 기준 방향(월드의 up 방향)
결과는 -180 ~ 180도 사이의 값

Vector3.Angle은 항상 0 ~ 180 사이의 절대값 각도만 반환합니다.
게임 에서는 회전 방향이 중요한 경우가 많기 때문에 -180 ~ 180 (음수) 이런 각도가 필요합니다.

 */

/*
 반환되는 각도는 처음 두 벡터 입력을 방향으로 처리할 때 첫 번째 벡터에서 두 번째 벡터로의 
 회전 각도입니다. 이 두 벡터는 또한 회전 평면을 정의하는데, 이는 평면에 평행하다는 것을 
 의미합니다. 이것은 각도가 계산되는 회전축이 첫 번째 및 두 번째 벡터의 교차곱임을 의미합니다 
 "왼손 규칙"을 사용하여 두 개의 입력 벡터가 주어지면 회전축을 결정할 수 있습니다. 
 세 번째 매개변수 axis는 계산에 포함할 상황별 방향을 제공하는 방법을 제공합니다. 
 이렇게 하면 사용자가 제공하는 이 세 번째 벡터가 처음 두 입력 벡터에 의해 
 정의된 회전 평면보다 높거나 낮은지 여부에 따라 결과의 부호가 대칭 이동하는 
 결과가 있습니다. 따라서 최종 결과의 부호는 "from" 및 "to" 벡터를 제공하는 순서와 
 세 번째 "축" 벡터의 방향에 따라 달라집니다. 참고: 반환되는 각도는 항상 -180도에서 180도 사이입니다.
 */

// Mathf.Sign 함수는 0이상이면 1, 0미만이면 -1값을 리턴하는 함수입니다.
/*
         - 함수의 내부 구현 확인 -
         1. 계산의 예 )
         from   = ( 0, 0, 1 )
         to     = ( 1, 0, 0 )
         axis   = ( 0, 1, 0 )

         1) 내적을 활용하여 두 벡터 사이의 각도를 구합니다. 두 벡터사이의 각도는 
            내적을 사용하여 구하였기 때문에 0~180사이의 각도가 됩니다.
         
         2) 두 벡터를 외적하여 두 벡터에 수직인 벡터를 구합니다. (외적벡터)
         3) 외적벡터와 세번째 매개변수인 axis를 곱하여 같은 방향성을 갖는지 찾습니다. 
         
            
         public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
        {
            // 두 벡터 사이의 각도를 구합니다. (0 ~ 180도 사이의 각도 )
            float num = Angle(from, to);
            
            // 두 벡터를 외적합니다. ( 외적하게 되면 두 벡터에 수직인 벡터가 만들어지게 됩니다. )
            float num2 = from.y * to.z - from.z * to.y;
            float num3 = from.z * to.x - from.x * to.z;
            float num4 = from.x * to.y - from.y * to.x;

            // Sign 함수를 사용하는 이유는 1 또는 -1값을 리턴하기 위함입니다.
            // 아래식에서 axis변수와 외적 벡터를 곱셈한 이유는 방향을 구하기 위해서 그렇습니다.
            // 같은 방향성을 갖는다면 양수가 나올 것이고, 다른 방향성을 갖는다면 두 벡터의 
            // 곱은 음수가 나오게 될 것입니다.
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
        Vector3 axis = Vector3.up;      // (0, 1, 0) 기준 회전축

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

        // 이 테스트 방식이 같은 방향성을 갖고 있는지 체크하는 코드입니다.
        float num5 = Mathf.Sign(0 * crossVector.x + 1 * crossVector.y + 0 * crossVector.z);

        // 역 방향을 체크하고 싶다면 (0,-1,0) 벡터값을 넣어 각도를 체크해야 합니다.
        //float num5 = Mathf.Sign(0 * crossVector.x + -1 * crossVector.y + 0 * crossVector.z);

        print(angle * num5);
    }

    void NegativeDirection()
    {
        // -- 아래의 코드는 두 벡터를 역으로 넣어 구했을때의 결과값을 체크하기 위한 코드입니다.

        float angle = Vector3.Angle(Vector3.right, Vector3.forward);
        print(angle);

        Vector3 crossVector = Vector3.Cross(Vector3.right, Vector3.forward);
        print(crossVector);

        float num5 = Mathf.Sign(0 * crossVector.x + -1 * crossVector.y + 0 * crossVector.z);
        print(angle * num5);
    }
}
