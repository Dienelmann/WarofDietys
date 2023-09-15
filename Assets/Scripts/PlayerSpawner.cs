using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public int yplayer = 1; 
    public int xplayer = 1;
    public float cDistanc = 0.5f;
    public float spacing;
    private List<GameObject> players = new List<GameObject>();

    private void Awake()
    {
        RefillSpawn();
    }

    public void RefillSpawn()
    {
        foreach (GameObject player in players)
        {
            Destroy(player);
        }
        players.Clear();
        for (int i = 0; i < xplayer; i++)
        {
            for (int j = 0; j < yplayer; j++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(i * (playerPrefab.transform.localScale.x + cDistanc), 
                    -j * (playerPrefab.transform.localScale.y + cDistanc));
                GameObject player = Instantiate(playerPrefab, spawnPos, Quaternion.identity);
                players.Add((playerPrefab));
            } 
        }
    }
    public void RemovePlayer(GameObject player)
    {
        players.Remove(player.gameObject);
        if (players.Count == 0)
        {
            RefillSpawn();
        }
    }
}