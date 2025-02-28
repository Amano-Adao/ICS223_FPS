using UnityEngine;

public class SceneController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private GameObject enemyPrefab;
    private GameObject enemy;
    private Vector3 spawnPoint = new Vector3(0, 0, 5);

    private const int numEnemies = 3;
    private GameObject[] enemies;

    private const int numIguanas = 5;
    [SerializeField] GameObject iguana;
    private GameObject[] iguanas;
    private GameObject iguanaObj;
    [SerializeField] private Transform iguanaSpawnPt;
    private void Start()
    {
        //enemyPrefab = GetComponent<GameObject>();
        //enemy = Instantiate(enemyPrefab as GameObject);
        enemies = new GameObject[numEnemies];
        iguanas = new GameObject[numIguanas];
        spawnIguanas();
        //enemies = {enemyPrefab as GameObject, enemyPrefab as GameObject, enemyPrefab as GameObject};
    }
    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < numEnemies; i++)
        {
            //Debug.Log("enemies array at:" + i + " is "+ enemies[i] == null);
            if (enemies[i] == null)
            {
                enemy = Instantiate(enemyPrefab as GameObject);
                enemy.transform.position = spawnPoint;
                float angle = Random.Range(0, 360);
                enemy.transform.Rotate(0, angle, 0);
                enemies[i] = enemy;
            }
        }
        
    }

    void spawnIguanas()
    {
        for (int i = 0; i < numIguanas; i++)
        {
            //Debug.Log("enemies array at:" + i + " is "+ enemies[i] == null);
            if (iguanas[i] == null)
            {
                iguanaObj = Instantiate(iguana as GameObject);
                iguanaObj.transform.position = iguanaSpawnPt.position;
                float angle = Random.Range(0, 360);
                iguanaObj.transform.Rotate(0, angle, 0);
                iguanas[i] = iguanaObj;
            }
        }
    }
}
