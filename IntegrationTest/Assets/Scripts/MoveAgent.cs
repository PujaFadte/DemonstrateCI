using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveAgent : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Move");
    }

    IEnumerator Move() {
        while (true) {
            agent.destination = new Vector3(Random.Range(-5, 5), 0, Random.Range(5,-5));
            yield return new WaitForSeconds(2.0f);
        }
    }
}
