using UnityEngine;

// Normalize함수는 벡터의 길이를 구한후, 이 길이값으로 요소를 나눠서 
// 길이를 1로 변경하는 함수입니다.
// 게임내에서는 특정 방향을 구하기 위한 벡터를 구할때 Normalize함수를 사용하거나
// normalized 속성값을 많이 사용하게 됩니다.
// 길이를 1인 벡터로 구하는 이유는 방향  * 스피드를 했을때 해당 방향을 가리키는 벡터를 
// 1로 구하면 해당 방향으로 주어진 스피드만큼 매시간 이동할 수 있기 때문입니다.

public class VectorNormalize : MonoBehaviour
{
    public Vector3 origin;
    public Vector3 transScale;
    public bool IsNormalize;

    void Start()
    {
        origin = new Vector3(3,4,0);
    }
    // 벡터의 길이 구하기
    // 루트 3^2 + 4^2 + 0^2 = 5

    // 각 성분을 정규화
    // 3/5, 4/5 , 0/5 = (0.6, 0.8, 0)

    // Update is called once per frame
    void Update()
    {        
        transScale = transform.localScale;
        if (IsNormalize)
        {
            transScale.Normalize();
            transform.localScale = transScale;
        }
        else
        transform.localScale = origin;
    }
}
