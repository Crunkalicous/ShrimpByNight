using UnityEngine;

public class WaterCapacity : MonoBehaviour
{
    private float maxWater = 100f;
    private float currentWater;
    private float leak = 5f;
    private float fill = 5f;


    private void Start()
    {
        currentWater = maxWater;
    }
    private void Update()
    {
        LosePlayerWater();
    }
    public float GetCurrentWater
    {
        get { return currentWater; }
    }

    public void LosePlayerWater()
    {
        currentWater -= leak * Time.deltaTime;
        if (currentWater <= 0)
        {
            return;
        }
        //Debug.Log("CurrentWater: " +  currentWater);
    }
    
    public void PlayerGainWater()
    {
        currentWater += fill * Time.deltaTime;
        //Debug.Log("CurrentWater: " + currentWater);
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        // Check if we hit an enemy
        if (other.CompareTag("Enemy"))
        {
            EnemyWater enemyWater = other.GetComponent<EnemyWater>();
            if (enemyWater != null)
            {
                    enemyWater.LoseEnemyWater();

                    PlayerGainWater();
            }
        }
    }
}
