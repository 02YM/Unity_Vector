using UnityEngine;

// ui를 사용한 이유는 평면적으로 보는것이 이해가 빠르기 
// 때문입니다.
// ui를 사용하였기 때문에 position 좌표를 사용하면 안됩니다.
// ui의 position은 최종적인 좌표이며 왼쪽 하단이 원점인 스크린좌표입니다.
// 따라서 각도를 체크하기 위해서 앵커를 중앙으로 설정하였으며
// localPosition을 활용하였습니다.

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
