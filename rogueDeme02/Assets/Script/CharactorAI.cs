using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharactorAI : MonoBehaviour
{
    private NavMeshAgent meshAgent;
    private Transform targetPos;


    // Start is called before the first frame update
    void Start()
    {
        meshAgent = gameObject.GetComponent<NavMeshAgent>();
        targetPos = GameObject.Find("Player").GetComponent<Transform>();

        meshAgent.updateRotation = false;
        meshAgent.updateUpAxis = false;

    }

    // Update is called once per frame
    void Update()
    {
        SetDestination(targetPos.position);
    }

    private void SetDestination(Vector3 pos)
    {
        float agentOffset = 0.001f;
        Vector3 agentPos = (Vector3)(agentOffset * Random.insideUnitCircle) + pos;
        meshAgent.SetDestination(agentPos);
    }
}
