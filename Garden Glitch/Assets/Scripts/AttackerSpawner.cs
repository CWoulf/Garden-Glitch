using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerPrefabs;

    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }
    private void SpawnAttacker()
    {
        int attackerIndex = Random.Range(0, attackerPrefabs.Length);
        Spawn(attackerPrefabs[attackerIndex]);

    }

    private void Spawn(Attacker attacker)
    {
        Attacker newAttackers = Instantiate(attacker, transform.position, Quaternion.identity) as Attacker;
        newAttackers.transform.parent = transform;
    }
    void Update()
    {
        
    }
}
