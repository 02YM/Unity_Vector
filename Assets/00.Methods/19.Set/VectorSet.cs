using UnityEngine;

public class VectorSet : MonoBehaviour
{

    public Vector3 end = new Vector3(-3, 1, -3);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            end.Set(-10, 1, 10);

            transform.position = end;

            //transform.poisition.set을 직접 사용하면 위차가 이동되지 않음
        }
    }
}
