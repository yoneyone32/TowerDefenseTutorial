using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WaveData", menuName = "TD/Create WaveData")]
public class WaveData : ScriptableObject
{
    public float intervalSec = 1.0f;
    public List<EnemyData> enemyDataList;
}
