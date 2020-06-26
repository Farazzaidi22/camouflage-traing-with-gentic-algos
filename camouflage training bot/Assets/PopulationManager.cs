using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationManager : MonoBehaviour
{
    public GameObject PersonPrefab;
    public int populationSize = 10;
    List<GameObject> population = new List<GameObject>();
    public static int elapsed;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i< populationSize; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-11, 11), Random.Range(-3, 5), 0);
            GameObject go = Instantiate(PersonPrefab, pos, Quaternion.identity);
            go.GetComponent<DNA>().r = Random.Range(0.0f, 1.0f);
            go.GetComponent<DNA>().g = Random.Range(0.0f, 1.0f);
            go.GetComponent<DNA>().b = Random.Range(0.0f, 1.0f);
            population.Add(go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
