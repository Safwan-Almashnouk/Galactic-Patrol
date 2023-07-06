using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;using static UnityEngine.GraphicsBuffer;

public class BossSpawn : MonoBehaviour
{

    public manager score;
    public GameObject Boss;
    private Transform target;
    private bool BossSpawned = false;

    void Start()
    {
        target = GameObject.Find("EnemySpawner").GetComponent<Transform>();
        
    }

    void Update()
    {
      
        if (score.playerScore >= 100 && GameObject.Find("Boss(Clone)") == null && !BossSpawned && GameObject.Find("enemyship(Clone)") == null && !BossSpawned || Input.GetKeyDown(KeyCode.P))
        {
            BossSpawning();
            BossSpawned= true;
        }
        

    }



    async public void BossSpawning()
        {
            await Task.Delay(0);
            //remove when building

                Instantiate(Boss, new Vector3(target.position.x + 5 , 1, target.position.z + 10), Quaternion.Euler(new Vector3(0, -0, 0)));
                BossSpawned = false;
            

        }

    }

