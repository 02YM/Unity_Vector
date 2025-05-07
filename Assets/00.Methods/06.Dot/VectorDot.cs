using UnityEngine;

// Dot 함수는 벡터의 내적 함수입니다.
// 벡터의 내적은 각 요소의 곱을 더한 값으로서 스칼라를 의미합니다.
// 스칼라의 뜻은 하나의 수치만으로 완전히 표시되는 양을 가리킵니다.
// 그리고 벡터의 내적을 해서 나오는 스칼라는 코사인 값이라고 할 수 있습니다.
// 현재 예제는 (0, 4, 0), (0,-4,0) 위치를 사용하고 있기 때문에
// 스칼라값은 -16이 나오게 됩니다.
// 단순하게 벡터적(벡터의 곱셈을 통한 길이)을 할 것이 아니라면
// 반드시 두 벡터를 길이가 1인 단위벡터로 만들어서 연산해줘야 합니다.
// Dot 함수를 사용해서 구한 코사인값은 비율 값이라고 생각하시면 됩니다.
// 이 비율 값을 라디안 단위의 각도로 변경해주는 함수가 바로 Mathf.Acos함수입니다.

// 라디안이란.?
/*
 반지름의 길이가 인 원 위에 길이가 인 호를 잡을 때, 이 호에 대한 중심각의 
크기는 반지름의 길이 에 관계없이 일정하다. 이때 이 크기를 단위로 하여 일반 각의 크기를 
측정하는 방법을 호도법이라고 하며 이 단위를 라디안(radian)이라고 한다.
오늘날 수학의 대부분의 분야에서 각을 라디안으로 측정하는 것이 통상적인데, 
각에 관한 다양한 식을 표현할 때 다른 단위보다 편리하기 때문이다.
 */

public class VectorDot : MonoBehaviour
{

    public Transform Top;
    public Transform Down;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 단순하게 벡터적을 할것이아니라면
        // 반드시 두 벡터를 길이가 1인 단위벡터로 만들어서 연산해줘야합니다.
        float dot = Vector3.Dot(Top.localPosition.normalized, Down.localPosition.normalized);

        // Dot 함수를 사용해서 구한 코사인 값은 비율값이라고 생각합니다.
        // 이 비율 값을 라디안 단위의 각도로 변경해주는 함수는 바로 Mathf.Acos 함수입니다.
        float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;

        print(angle);
    }
}
