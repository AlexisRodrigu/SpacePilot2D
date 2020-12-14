using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<WaveConfiguration> _waveConfigurations;
    [SerializeField] private int startWave = 0;
    [SerializeField] private bool loop = false;

    private IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(SpawnAllEnemies());
        } while (loop);
    }

    private IEnumerator SpawnAllEnemiesInWave(WaveConfiguration waveConfiguration)
    {
        for (int enemyCount = 0; enemyCount < waveConfiguration.GetNumberEnemies(); enemyCount++)
        {
            GameObject newEnemy = Instantiate(waveConfiguration.GetEnemyPrefab(),
                waveConfiguration.GetWayPoints()[0].transform.position, Quaternion.identity);
            newEnemy.GetComponent<EnemyFollowPath>().SetWaveConfig(waveConfiguration);
            yield return new WaitForSeconds(waveConfiguration.GetTimeBeetweenSpaws());

        }
    }

    private IEnumerator SpawnAllEnemies()
    {
        for (int waveIndex = startWave; waveIndex < _waveConfigurations.Count; waveIndex++)
        {
            var currentWave = _waveConfigurations[waveIndex];
            yield return StartCoroutine(SpawnAllEnemiesInWave(currentWave));
        }
    }
}
