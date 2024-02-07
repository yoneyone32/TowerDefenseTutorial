using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] EnemyData enemyData;
    [SerializeField] tower tower;

    private float hp;
    private float power;
    private float speed;

    public void Initialize(EnemyData enemyData, LineRenderer lineRenderer, tower tower)
    {
        this.enemyData = enemyData;

        hp = enemyData.maxHP;
        power = enemyData.power;
        speed = enemyData.speed;
        GetComponent<LineMover>().SetSpeed(speed);

        var spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = enemyData.enemySprite;

        var lineMover = GetComponent<LineMover>();
        lineMover.Initialize(0, speed, lineRenderer);

        this.tower = tower;

        lineMover.OnEndReached += (sender, e) =>
        {
            Debug.Log("Ç®èÈÇ…ìûíÖÇµÇΩÇÊ");
            if (tower != null)
            {
                tower.TakeDamage(power);

                var impulseSource = GetComponent<CinemachineImpulseSource>();
                impulseSource.GenerateImpulse(0.1f);
            }
            Destroy(gameObject);
        };
    }
}
