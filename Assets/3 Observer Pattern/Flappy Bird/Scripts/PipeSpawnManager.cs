using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnManager : MonoBehaviour
{
    public GameObject objectToPool;
    public int poolSize;
    List<GameObject> pooledObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }
    //public GameObject GetObjectFromPool()
    //{
    //    for (int i = 0; i < pooledObjects.Count; i++)
    //    {
    //        if (!pooledObjects[i].activeInHierarchy)
    //        {
    //            return pooledObjects[i];
    //        }
    //    }

    //    GameObject obj = Instantiate(objectToPool);
    //    obj.SetActive(false);
    //    pooledObjects.Add(obj);

    //    return obj;
    //}
    // Update is called once per frame
    void Update()
    {
        
    }
}
