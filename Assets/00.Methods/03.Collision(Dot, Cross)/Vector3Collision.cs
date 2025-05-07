using UnityEngine;


namespace Game
{
    public class Collision
    {
        // 내적을 활용한 충돌처리
        public static bool CollisionDot(Vector3 playerPosition,
                                        Vector3 playerForward,
                                        Vector3 targetPosition,
                                        float distance,
                                        float angle)
        {
            Vector3 targetDir = (targetPosition - playerPosition).normalized;
            // 플레이어의 전방벡터와 타겟을 향하는 벡터의 내적을 구해서 각도를 구합니다.
            float targetCos = Vector3.Dot(playerForward, targetDir);
            float targetAngle = Mathf.Acos(targetCos) * Mathf.Rad2Deg;
            // 플레이어와 타겟과의 거리를구합니다.
            float targetDistance = Vector3.Distance(playerPosition, targetPosition);
            // 충돌이 되었다고 처리합니다.
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
            // 공격 범위를 벗어났다면 false값을 리턴합니다.
            if (Vector3.Distance(playerPosition, targetPosition) > distance)
                return false;

            Vector3 _1 = Vector3.Cross(forwardDir, targetPosition);
            Vector3 _2 = Vector3.Cross(leftDir, targetPosition);
            Vector3 _3 = Vector3.Cross(rightDir, targetPosition);

            // 전방벡터의 왼쪽에 위치하고, 왼쪽 벡터의 오른쪽에 배치되어 있다면 true값을 리턴합니다.
            if (_1.y <= 0 && _2.y >= 0)
                return true;

            if (_1.y >= 0 && _3.y <= 0)
                return true;

            return false;
        }
    }
}
