using UnityEngine;

public class VectorScale2 : MonoBehaviour
{

    public Vector3 orgin = new Vector3(1, 1, 1);
    public Vector3 trans = new Vector3(3, 3, 3);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            transform.localScale = Vector3.Scale(orgin, trans);
        }
    }
}
