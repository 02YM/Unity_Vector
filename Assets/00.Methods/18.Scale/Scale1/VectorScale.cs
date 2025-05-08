using UnityEngine;

// Scale 함수는 현재의 값이 매개변수의 값과 곱해지는 함수입니다.

public class VectorScale : MonoBehaviour
{
    public Vector3 scale = new Vector3(10, 10, 10);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {

            scale.Scale(new Vector3(20, 1, 20));
            // (20 * 10, 1 * 10, 20 * 10)

            transform.localScale = scale;
        }
    }
}
