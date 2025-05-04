using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public Transform shootPoint;             // �ش������ع���ԧ�͡��
    public Transform target;                 // Kuromi ��Ǽ�����
    public Rigidbody2D bulletPrefab;         // ����ع

    public float shootInterval = 2f;         // �ԧ�ء����Թҷ�
    private float shootTimer;

    Vector2 CalculateProjectileVelocity(Vector2 origin, Vector2 target, float time)
    {
        Vector2 distance = target - origin;

        float velocityX = distance.x / time;
        float velocityY = distance.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y) * time;

        return new Vector2(velocityX, velocityY);
    }

    void Update()
    {
        shootTimer += Time.deltaTime;

        if (shootTimer >= shootInterval)
        {
            shootTimer = 0f;  // ���� Timer

            if (target != null)
            {
                // �ӹǳ��������
                Vector2 projectileVelocity = CalculateProjectileVelocity(shootPoint.position, target.position, 1f);

                // ���ҧ����ع����
                Rigidbody2D firedBullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

                // ����������������ع
                firedBullet.linearVelocity = projectileVelocity;

                // ���������ع������ѧ 5 �Թҷ�
                Destroy(firedBullet.gameObject, 5f);
            }
        }
    }
}
