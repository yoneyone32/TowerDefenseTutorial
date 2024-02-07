using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public WaveData waveData;
    public LineRenderer lineRenderer;
    public tower tower;
    public EnemyManager enemyPrefab;

    public float timer = 0.0f;
    public int enemyIndex = 0;

    void Start()
    {
        timer = waveData.intervalSec;
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= waveData.intervalSec)
        {
            timer = 0.0f;

            EnemyData enemyData = waveData.enemyDataList[enemyIndex];

            if(enemyData != null )
            {
                var enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                enemy.Initialize(enemyData, lineRenderer, tower);
            }

            enemyIndex++;

            if(enemyIndex >= waveData.enemyDataList.Count)
            {
                this.enabled = false;
            }
        }
    }
}
