using UnityEngine;


namespace Game
{
    public class Collision
    {
        // ������ Ȱ���� �浹ó��
        public static bool CollisionDot(Vector3 playerPosition,
                                        Vector3 playerForward,
                                        Vector3 targetPosition,
                                        float distance,
                                        float angle)
        {
            Vector3 targetDir = (targetPosition - playerPosition).normalized;
            // �÷��̾��� ���溤�Ϳ� Ÿ���� ���ϴ� ������ ������ ���ؼ� ������ ���մϴ�.
            float targetCos = Vector3.Dot(playerForward, targetDir);
            float targetAngle = Mathf.Acos(targetCos) * Mathf.Rad2Deg;
            // �÷��̾�� Ÿ�ٰ��� �Ÿ������մϴ�.
            float targetDistance = Vector3.Distance(playerPosition, targetPosition);
            // �浹�� �Ǿ��ٰ� ó���մϴ�.
            if (targetAngle <= angle && distance >= targetDistance) 
                return true;
            return false;
        }

        public static bool CollisionCross(Vector3 playerPosition,
                                           Vector3 forwardDir,
                                           Vector3 leftDir,
                                           Vector3 rightDir,
                                           Vector3 targetPosition,
                                           float distance)
        {
            // ���� ������ ����ٸ� false���� �����մϴ�.
            if (Vector3.Distance(playerPosition, targetPosition) > distance)
                return false;

            Vector3 _1 = Vector3.Cross(forwardDir, targetPosition);
            Vector3 _2 = Vector3.Cross(leftDir, targetPosition);
            Vector3 _3 = Vector3.Cross(rightDir, targetPosition);

            // ���溤���� ���ʿ� ��ġ�ϰ�, ���� ������ �����ʿ� ��ġ�Ǿ� �ִٸ� true���� �����մϴ�.
            if (_1.y <= 0 && _2.y >= 0)
                return true;

            if (_1.y >= 0 && _3.y <= 0)
                return true;

            return false;
        }
    }
}
