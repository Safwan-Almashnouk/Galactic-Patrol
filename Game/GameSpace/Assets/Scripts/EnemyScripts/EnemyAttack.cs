using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class EnemyAttack : MonoBehaviour
{

    public GameObject Bullet;
    private bool IsAttacking = false;
    public Transform SpawnArea;
    // Start is called before the first frame update


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsAttacking)
        {
            EnemyShooting();
            IsAttacking = true;
        }
        
    }

    async public void EnemyShooting()
    {
        //delays for 1000 miliseconds / 1 seconds
        await Task.Delay(1000);
        #if UNITY_EDITOR
        if (UnityEditor.EditorApplication.isPlaying)
        {
            Instantiate(Bullet, SpawnArea.position, SpawnArea.rotation);
            IsAttacking = false;
        }
        #endif
    }
}
