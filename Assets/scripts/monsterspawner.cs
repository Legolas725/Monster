//using System.Collections;
//using System.Collections.Generic;
//using System.Threading;
//using UnityEngine;

//public class monsterspawner : MonoBehaviour
//{

//    [SerializeField]
//    private GameObject[] monsterReference;

//    private GameObject spawnedMonster;


//    [SerializeField]
//    private Transform leftpos, rightpos;

//    private int randomIndex;
//    private int randomSide;
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    IEnumerator SpawnMonsters()
//    {

//        while (true)
//        {

//            yield return new WaitForSeconds(Random.Range(1, 5));

//            randomIndex = Random.Range(0, monsterReference.Length);
//            randomSide = Random.Range(0, 2);

//            spawnedMonster = Instantiate(monsterReference[randomIndex]);

//            // left side
//            if (randomSide == 0)
//            {

//                spawnedMonster.transform.position = leftpos.position;
//                spawnedMonster.GetComponent<monster>().speed = Random.Range(4, 10);

//            }
//            else
//            {
//                // right side
//                spawnedMonster.transform.position = rightpos.position;
//                spawnedMonster.GetComponent<monster>().speed = -Random.Range(4, 10);
//                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);

//            }

//        } // while loop

//    }


//} // class





//using System.Collections;
//using System.Collections.Generic;
//using System.Threading;
//using UnityEngine;

//public class MonsterSpawner : MonoBehaviour
//{

//    [SerializeField]
//    private GameObject[] monsterReference;

//    private GameObject spawnedMonster;

//    [SerializeField]
//    private Transform leftPos, rightPos;

//    private int randomIndex;
//    private int randomSide;

//    // Start is called before the first frame update
//    void Start()
//    {
//        StartCoroutine(Spa wnMonsters());
//    }

//    IEnumerator SpawnMonsters()
//    {

//        while (true)
//        {

//            yield return new WaitForSeconds(Random.Range(1, 5));

//            randomIndex = Random.Range(0, monsterReference.Length);
//            randomSide = Random.Range(0, 2);

//            spawnedMonster = Instantiate(monsterReference[randomIndex]);

//            // left side
//            if (randomSide == 0)
//            {

//                spawnedMonster.transform.position = leftPos.position;
//                spawnedMonster.GetComponent<monster>().speed = Random.Range(4, 10);

//            }
//            else
//            {
//                // right side
//                spawnedMonster.transform.position = rightPos.position;
//                spawnedMonster.GetComponent<monster>().speed = -Random.Range(4, 10);
//                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);

//            }

//        } // while loop

//    }


//} // class





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedMonster;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {

        while (true)
        {

            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, monsterReference.Length);
            randomSide = Random.Range(0, 2);

            spawnedMonster = Instantiate(monsterReference[randomIndex]);

            // left side
            if (randomSide == 0)
            {

                spawnedMonster.transform.position = leftPos.position;
                spawnedMonster.GetComponent<monster>().speed = Random.Range(4, 10);

            }
            else
            {
                // right side
                spawnedMonster.transform.position = rightPos.position;
                spawnedMonster.GetComponent<monster>().speed = -Random.Range(4, 10);
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);

            }

        } // while loop

    }


} // class





















































































