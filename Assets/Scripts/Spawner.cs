using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Transform _respawnPoints;

    private Transform[] _respawns;

    private void Start()
    {
        _respawns = new Transform[_respawnPoints.childCount];

        for (int i = 0; i < _respawnPoints.childCount; i++)
        {
            _respawns[i] = _respawnPoints.GetChild(i);
        }

        StartCoroutine(CreateBots());
    }

    private IEnumerator CreateBots()
    {
        float timeRespawn = 2f;
        var waitForSeconds = new WaitForSeconds(timeRespawn);

        while (true)
        {
            for (int i = 0; i < _respawns.Length; i++)
            {
                GameObject bot = Instantiate(_prefab.gameObject, _respawns[i].position, Quaternion.identity);

                yield return waitForSeconds;
            }
        }
    }
}