using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class wavespawn : MonoBehaviour
{
    public enum SpawnState {SPAWNING, WAITING, COUNTING};

            [System.Serializable]

            public class Wave
            {
                public string name;
                public Transform enemy;
                public int count;
                public float rate;
            }

            public Wave[] waves;
            private int nextWave = 0;
            public Transform[] spawnPoints;
            public float timeBetweenWaves = 500f;
            public float waveCountdown;

            private float searchCountdown = 1f;

            private SpawnState state = SpawnState.COUNTING;

            void Start()
        {
            if (spawnPoints.Length == 0)
            {
                Debug.Log("no spawn point referenced");
            }
            waveCountdown = timeBetweenWaves;
        }

            void Update()
        {
            if (state == SpawnState.WAITING)
            {
               if (!EnemyIsAlive())
            {
                //begin a new round 
                WaveCompleted();
            }
            else
            {
                return;
            } 
            }
            if (waveCountdown <= 0)
            {
                
                searchCountdown =1f;

                if(state != SpawnState.SPAWNING)
                {
                StartCoroutine( SpawnWave ( waves[nextWave] ));
                }
            }
                else
                {
                    waveCountdown -= Time.deltaTime;
                }
        }

        void WaveCompleted()
        {
            Debug.Log("wave completed!");
            state = SpawnState.COUNTING;
            waveCountdown = timeBetweenWaves;
            if (nextWave +1 > waves.Length -1)
            {
                nextWave = 0;
                Debug.Log("all waves complete!");
            }
            else
            {
               nextWave++; 
            }
        }

        bool EnemyIsAlive()
        {
            searchCountdown -= Time.deltaTime;
            if (searchCountdown <= 0f)
            {
                searchCountdown = 1f;

                if(GameObject.FindGameObjectWithTag("Enemy")==null)
                    {
                        return false;

                    }
            }
            
            return true;
        }

        IEnumerator SpawnWave(Wave _wave)
        {
            Debug.Log("spawning wave :"+_wave.name);

            state = SpawnState.SPAWNING;

                for (int i=0 ; i< _wave.count ; i++)
                {
                SpawnEnemy(_wave.enemy);
                yield return new WaitForSeconds( 1f/_wave.rate);
                }
            state = SpawnState.WAITING;
            yield break;
        }

        void SpawnEnemy(Transform _enemy)
        {
            Debug.Log("Spawning enemy: "+ _enemy.name);
            if (spawnPoints.Length == 0)
            {
                Debug.Log("no spawn point referenced");
            }
            Transform _sp = spawnPoints  [Random.Range(0,spawnPoints.Length)];
            Instantiate (_enemy,_sp.position , _sp.rotation);
        }

}


