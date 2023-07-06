using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class EnemySpawning : MonoBehaviour
{
    
    public GameObject Enemy;
    Transform target;
    public bool IsSpawning = false;
    

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("EnemySpawner").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //if gameobject is not in game
        if(GameObject.Find("enemyship(Clone)") == null && !IsSpawning && GameObject.Find("Boss(Clone)") == null && !IsSpawning)
        {
            IsSpawning = true;
            spawnEnemy();
        }
       
        

    }

    async public void spawnEnemy()
    {   await Task.Delay(5000);
        //remove when building
        #if UNITY_EDITOR
        if(UnityEditor.EditorApplication.isPlaying){
            Instantiate(Enemy, new Vector3(target.position.x + 5, -1, 0), Quaternion.Euler(new Vector3(0, -90, 0)));
            IsSpawning = false;
        }
        #endif
    }
    

    }

