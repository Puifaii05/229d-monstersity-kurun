using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public Transform shootPoint;             // จุดที่กระสุนจะยิงออกมา
    public Transform target;                 // Kuromi ตัวผู้เล่น
    public Rigidbody2D bulletPrefab;         // กระสุน

    public float shootInterval = 2f;         // ยิงทุกกี่วินาที
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
            shootTimer = 0f;  // รีเซ็ต Timer

            if (target != null)
            {
                // คำนวณความเร็ว
                Vector2 projectileVelocity = CalculateProjectileVelocity(shootPoint.position, target.position, 1f);

                // สร้างกระสุนใหม่
                Rigidbody2D firedBullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

                // ใส่ความเร็วให้กระสุน
                firedBullet.linearVelocity = projectileVelocity;

                // สั่งให้กระสุนหายไปหลัง 5 วินาที
                Destroy(firedBullet.gameObject, 5f);
            }
        }
    }
}
