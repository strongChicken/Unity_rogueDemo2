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

        meshAgent.updateRotation = false;
        meshAgent.updateUpAxis = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (targetPos == null)
        {
            return;
        }
        SetDestination(targetPos.position);
    }

    // 纠正Nav组件问题
    private void SetDestination(Vector3 pos)
    {
        float agentOffset = 0.001f;
        Vector3 agentPos = (Vector3)(agentOffset * Random.insideUnitCircle) + pos;
        meshAgent.SetDestination(agentPos);
    }

    public void setNavTarget(Transform target)
    {
        targetPos = target;
    }
}
