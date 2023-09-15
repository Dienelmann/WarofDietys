using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject player = null;
    [SerializeField] private GameObject enemy = null;
    [SerializeField] private Slider playerhealth = null;
    [SerializeField] private Slider enemyhealth = null;
    [SerializeField] private Button AttackBtn = null;
    [SerializeField] private Button HealBtn = null;
    [SerializeField] private Slider expbar = null;
    int randomattack = 0;
    int randomheal = 0;
    public int Exp = 50;
    public Text levelText;
    public int minattack = 10;
    public int maxattack = 21;
    public int minheal = 5;
    public int maxheal = 16;
    private int eminattack = 5;
    private int emaxattack = 16;
    private int eminheal = 5;
    private int emaxheal = 11;
    private int LevelNumber = 1;

    

    public bool isPlayerTurn = true;

    /*private void Attack(GameObject target, float damage)
    {
        if (target == enemy)
        {
            enemyhealth.value -= damage;
            playerani = GameObject.FindWithTag("Player").GetComponent<PlayerAni>();
            playerani.Attack();
            enemyani = GameObject.FindWithTag("Enemy").GetComponent<EnemyAni>();
            enemyani.EHurt();
            
        }
        else
        {
            playerhealth.value -= damage;
            enemyani = GameObject.FindWithTag("Enemy").GetComponent<EnemyAni>();
            enemyani.EAttack();
            playerani = GameObject.FindWithTag("Player").GetComponent<PlayerAni>();
            playerani.Hurt();
            
        }
        
        ChangeTurn();
    }

    private void Heal(GameObject target, float amount)
    {
        if (target == player)
        {
            playerhealth.value += amount;
            playerani = GameObject.FindWithTag("Player").GetComponent<PlayerAni>();
            playerani.Heal();
        }
        else
        {
            enemyhealth.value += amount;
            enemyani = GameObject.FindWithTag("Enemy").GetComponent<EnemyAni>();
            enemyani.EHeal();
        }
        
        ChangeTurn();
    }

    

    public void BtnAttack()
    {
        Attack(enemy, 10);
    }

    public void BtnHeal()
    {
        Heal(player, 5);
    }

    private void ChangeTurn()
    {
        isPlayerTurn = !isPlayerTurn;

        if (!isPlayerTurn)
        {
            AttackBtn.interactable = false;
            HealBtn.interactable = false;
            StartCoroutine(EnemyTurn());
            if (playerhealth.value <= 0)
            {
                playerani = GameObject.FindWithTag("Player").GetComponent<PlayerAni>();
                playerani.Dead();
            }
            
        }
        else
        {
            if (enemyhealth.value <= 0)
            {
                enemyani = GameObject.FindWithTag("Enemy").GetComponent<EnemyAni>();
                enemyani.EDeath();
                
                expbar.value += Exp;
                if (expbar.value >= expbar.maxValue)
                {
                    expbar.value = 0;
                    LevelUp();
                    SetLevelNumber();
                    expbar.maxValue *= 1.5f;
                }
                if (enemySpawner.enemys.Count > 0)
                {
                    Destroy(enemySpawner.enemys[0]); 
                }
                print("You won the Fight");
                enemyhealth.value = enemyhealth.maxValue;
                StartCoroutine(NewEnemy());
            }
            StartCoroutine(PlayerTurn());
            
        }
    }

    private void LevelUp()
    {
        minattack += 5;
        maxattack *= 2;
        minheal += 5;
        maxheal *= 2;
        playerhealth.maxValue *= 1.5f;
        refillhealth();
    }

    private void refillhealth()
    {
        playerhealth.value = playerhealth.maxValue;
    }

    private IEnumerator EnemyTurn()
    {
        
        yield return new WaitForSeconds(3);
        

        int random = 0;
        random = Random.Range(1, 5);
        randomattack = Random.Range(eminattack, emaxattack);
        randomheal = Random.Range(eminheal, emaxheal);

        if (random <= 2)
        {
           Attack(player, randomattack); 
        }
        else
        {
            Heal(enemy, randomheal);
            
        }
        

    }

    public IEnumerator PlayerTurn()
    {
        
        yield return new WaitForSeconds(3);
        

        int random = 0;
        random = Random.Range(1, 5);
        randomattack = Random.Range(minattack, maxattack);
        randomheal = Random.Range(minheal, maxheal);

        if (random <= 2)
        {
            Attack(enemy, randomattack);
            
        }
        else
        {
            Heal(player, randomheal);
        }
        
        
    }

    private IEnumerator NewEnemy()
    {
        yield return new WaitForSeconds(2);
        enemySpawner.RefillSpawn();
        yield return new WaitForSeconds(2);
    }
    
    private void SetLevelNumber()
    {
        levelText.text = "LEVEL: " + (LevelNumber ++);
    }*/

}
