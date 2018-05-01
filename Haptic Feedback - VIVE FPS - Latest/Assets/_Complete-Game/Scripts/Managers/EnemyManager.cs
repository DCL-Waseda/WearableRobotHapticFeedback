using UnityEngine;

namespace CompleteProject
{
    public class EnemyManager : MonoBehaviour
    {
        public PlayerHealth playerHealth;       // Reference to the player's heatlh.

        // The enemy prefabs to be spawned.
        public GameObject enemyBunnySpawn;      
        public GameObject enemyBearSpawn;
        public GameObject enemyElephantSpawn;
        public GameObject enemyZombieSpawn;
        public float spawnTime = 3f;            // How long between each spawn.
        public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
        public int cycleCounter = 0;

        //Array for enemy location **Important**
        // spawnPoints[] Array contains the spawn locations for the enemies.
        //0 ZomBunny
        //1 ZomBear
        //2 ZomBunny2
        //3 Hellephant

        private void Start()
        {
            Debug.Log("Press Numpad 1,2,3,5 to spawn Bunny,Bear and Hellephant. \n Press Numpad 0 to start repeating spawn.");
            Debug.Log("Press Numpad + to stop spawning. \n Press 'c' to destroy all enemies");
        }
        private void Update()
        {
            //Keyboard input
            if (Input.GetKeyDown(KeyCode.Keypad0))
            {
                InvokeRepeating("Spawn", spawnTime, spawnTime);
                cycleCounter = 0;
            }
            else if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                SpawnBunny();
                Debug.Log("Spawned Bunny");
            }
            else if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                SpawnZombie();
                Debug.Log("Spawned Zombie");
            }
            else if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                SpawnBear();
                Debug.Log("Spawned Bear");
            }
            else if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                SpawnElephant();
                Debug.Log("Spawned Elephant");
            }
            else if (Input.GetKeyDown(KeyCode.KeypadPlus))
            {
                CancelInvoke();
                Debug.Log("Stopped spawning");
            }
            else if (Input.GetKeyDown("c"))
            {
                Debug.Log("Destroying all enemies");
                var Bearclones = GameObject.FindGameObjectsWithTag("BearClone");
                foreach (var clone in Bearclones)
                {
                    Destroy(clone);
                }
                var Bunnyclones = GameObject.FindGameObjectsWithTag("BunnyClone");
                foreach (var clone in Bunnyclones)
                {
                    Destroy(clone);
                }
                var Zombieclones = GameObject.FindGameObjectsWithTag("ZombieClone");
                foreach (var clone in Zombieclones)
                {
                    Destroy(clone);
                }
                var Elephantclones = GameObject.FindGameObjectsWithTag("ElephantClone");
                foreach (var clone in Elephantclones)
                {
                    Destroy(clone);
                }
            }
        }

        //Spawning Functions
        void SpawnBunny()
        {
            GameObject tempClone = Instantiate(enemyBunnySpawn, spawnPoints[0].position, spawnPoints[0].rotation);
        }
        void SpawnBear()
        {
            GameObject tempClone = Instantiate(enemyBearSpawn, spawnPoints[1].position, spawnPoints[1].rotation);
        }
        void SpawnZombie()
        {
            GameObject tempClone = Instantiate(enemyZombieSpawn, spawnPoints[2].position, spawnPoints[2].rotation);
        }       
        void SpawnElephant()
        {
            GameObject tempClone = Instantiate(enemyElephantSpawn, spawnPoints[3].position, spawnPoints[3].rotation);
        }

        // Repeating Spawn
        void Spawn ()
        {
            Debug.Log("Spawning started");
            // If the player has no health left...
            if(playerHealth.currentHealth <= 0f)
            {
                // ... exit the function.
                return;
            }

            //cycleCounter to cycle between enemies and spawn locations
            //Debug.Log(cycleCounter);    
            cycleCounter++;
            GameObject BunnyClone = Instantiate(enemyBunnySpawn, spawnPoints[0].position, spawnPoints[0].rotation);
            GameObject BearClone = Instantiate(enemyBearSpawn, spawnPoints[1].position, spawnPoints[1].rotation);


            if (cycleCounter % 2 == 0) //For all even spawn counter
            {
                GameObject ZombieClone = Instantiate(enemyZombieSpawn, spawnPoints[2].position, spawnPoints[2].rotation);
            }
            if (cycleCounter % 3 == 0) // Spawn counter is a multiple of 3
            {
                GameObject ElephantClone = Instantiate(enemyElephantSpawn, spawnPoints[3].position, spawnPoints[3].rotation);
            }
           }
    }
}