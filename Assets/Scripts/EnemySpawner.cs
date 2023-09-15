using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int yenemy = 1; 
    public int xenemy = 1;
    public float cDistanc = 0.5f;
    public float spacing;
    public List<GameObject> enemys = new List<GameObject>();

    private void Start()
    {
        
        RefillSpawn();
        
    }


    

    public void RefillSpawn()
    {
        foreach (GameObject enemy in enemys)
        {
            Destroy(enemy);
        }
        enemys.Clear();
        for (int i = 0; i < xenemy; i++)
        {
            for (int j = 0; j < yenemy; j++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(i * (enemyPrefab.transform.localScale.x + cDistanc),
                    -j * (enemyPrefab.transform.localScale.y + cDistanc));
                GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
                enemys.Add((enemy));
            } 
        }
    }
    public void RemoveEnemy(GameObject enemy)
    {
        enemys.Remove(enemy.gameObject);
        if (enemys.Count == 0)
        {
            RefillSpawn();
        }
    }
}
