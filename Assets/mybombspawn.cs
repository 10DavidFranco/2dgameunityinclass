using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mybombspawn : MonoBehaviour
{

    public GameObject itemPrefab;
    public float r;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 5; i++)
        {
            spawObject();
        }

    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.B))
        // {
        //   spawObject();
        // }
    }

    void spawObject()
    {

        Vector2 randomPos = Random.insideUnitCircle * r;
        Instantiate(itemPrefab, randomPos, Quaternion.identity);

    }
}