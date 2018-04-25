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
        public GameObject enemyBunny2Spawn;
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
            }
            else if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                SpawnBunny2();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                SpawnBear();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                SpawnElephant();
            }
            else if (Input.GetKeyDown(KeyCode.KeypadPlus))
            {
                CancelInvoke();
            }
            else if (Input.GetKeyDown("c"))
            {
                Debug.Log("Destroying all enemies");
                var clones = GameObject.FindGameObjectsWithTag("clone");
                foreach (var clone in clones)
                {
                    Destroy(clone);
                }
            }
        }

        //Spawning Functions
        void SpawnBunny()
        {
            GameObject tempClone = Instantiate(enemyBunnySpawn, spawnPoints[0].position, spawnPoints[0].rotation);
            tempClone.tag = "clone";
            Debug.Log("Spawned Bunny");
        }
        void SpawnBear()
        {
            GameObject tempClone = Instantiate(enemyBearSpawn, spawnPoints[1].position, spawnPoints[1].rotation);
            tempClone.tag = "clone";
            Debug.Log("Spawned Bear");
        }
        void SpawnBunny2()
        {
            GameObject tempClone = Instantiate(enemyBunny2Spawn, spawnPoints[2].position, spawnPoints[2].rotation);
            tempClone.tag = "clone";
            Debug.Log("Spawned Bunny2");
        }       
        void SpawnElephant()
        {
            GameObject tempClone = Instantiate(enemyElephantSpawn, spawnPoints[3].position, spawnPoints[3].rotation);
            tempClone.tag = "clone";
            Debug.Log("Spawned Elephant");
        }

        // Repeating Spawn
        void Spawn ()
        {
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

            BearClone.tag = "clone";
            BunnyClone.tag = "clone";

            if (cycleCounter % 2 == 0) //For all even spawn counter
            {
                GameObject Bunny2Clone = Instantiate(enemyBunny2Spawn, spawnPoints[2].position, spawnPoints[2].rotation);
                Bunny2Clone.tag = "clone";
            }
            if (cycleCounter % 3 == 0) // Spawn counter is a multiple of 3
            {
                GameObject ElephantClone = Instantiate(enemyElephantSpawn, spawnPoints[3].position, spawnPoints[3].rotation);
                ElephantClone.tag = "clone";
            }
           }
    }
}