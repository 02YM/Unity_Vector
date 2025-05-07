using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 leftDir = Vector3.zero;
    private Vector3 forwardDir = Vector3.zero;
    private Vector3 rightDir = Vector3.zero;

    // �׷��� ���� ��
    public float drawLength = 2;

    // üũ�� ����
    public float angle = 50;

    // ����𿡼� �����ֱ� ���� ���
    public Color forwardColor = Color.blue;
    public Color leftColor = Color.yellow;
    public Color rightColor = Color.red;

    public Transform target;

    public LayerMask enemyLayer;
    
    void Start()
    {
        GameObject obj = GameObject.Find("Enemy");
        if(obj != null)
            target = obj.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // ���̰� 1�� ����
        forwardDir = transform.forward;
        Quaternion rot = Quaternion.AngleAxis(-angle, Vector3.up);
        leftDir = rot * forwardDir;

        rot = Quaternion.AngleAxis(angle, Vector3.up);
        rightDir = rot * forwardDir;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �ݰ濡 �ִ� ��� ĳ���͸� �޽��ϴ�.
            Collider[] colliders = Physics.OverlapSphere(transform.position, drawLength, enemyLayer);
            bool state = false;
            //bool state = Game.Collision.CollisionDot(transform.position,
            //                            forwardDir,
            //                            target.position,
            //                            drawLength,
            //                            angle);
            //bool state = Game.Collision.CollisionCross(transform.position,
            //                                           forwardDir,
            //                                           leftDir,
            //                                           rightDir,
            //                                           target.position,
            //                                           drawLength);

            float targetAngle = Vector3.Angle(forwardDir, (target.position - transform.position).normalized);
            float targetDistance = Vector3.Distance(transform.position, target.position);

            if (targetAngle <= angle && targetDistance < drawLength)
                state = true;

            if (state)
                print("�浹");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = forwardColor;
        Gizmos.DrawLine(transform.position, transform.position + forwardDir * drawLength);
        Gizmos.color = leftColor;
        Gizmos.DrawLine(transform.position, transform.position + leftDir * drawLength);
        Gizmos.color = rightColor;
        Gizmos.DrawLine(transform.position, transform.position + rightDir * drawLength);
    }
}
