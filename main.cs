using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muncul : MonoBehaviour
{
    public GameObject virus;
    public float mintime, maxtime;
    public float minposition, maxposition;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MunculVirus()
    {
        Instantiate(virus, transform.position + Vector3.right*Random.Range(minposition,maxposition)
            , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(mintime,maxtime));
        StartCoroutine(MunculVirus());
    }
}
