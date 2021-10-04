using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusDistanceManager : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;

    public float distanceBetweenGoTrigger;

    private void Start()
    {
        target1.transform.GetChild(0).localPosition = Vector3.zero;
        target2.transform.GetChild(0).localPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        bool condition = false;
        if(Vector3.Distance(target1.transform.position, target2.transform.position) < distanceBetweenGoTrigger)
        {
            if(condition == false)
            {
                target1.transform.GetChild(0).GetComponent<Animator>().Play("Attack");
                target2.transform.GetChild(0).GetComponent<Animator>().Play("Attack");
            }
            condition = true;
        }
        Debug.Log(condition);
    }

    public void OnTargetLose()
    {
        target1.transform.position = new Vector3(1000, 0, 0);
        target2.transform.position = new Vector3(-1000, 0, 0);
    }
}
