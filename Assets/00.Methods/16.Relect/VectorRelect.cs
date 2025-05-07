using UnityEngine;

// 이함수를 사용하실때 생각해보실점은 특정 위치를 가리킬때의 방향이
// 직교 좌표계에서는 원점에서 특정 지점을 가리키도록 되어 있다는 것입니다.

// 첫번째 매개변수의 값은 반사벡터를 구하고자 하는 값입니다.
// 두번째 매개변수의 값은 기준 라인을 설정한다고 보시면 됩니다.
// 기준값을 설정하는 라인이기에 left, right는 동일한 값
// up, down도 동일한 값이 된다고 보시면 됩니다.


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
