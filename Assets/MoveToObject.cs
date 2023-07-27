using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToObject : MonoBehaviour
{
    private NavMeshAgent agent;

    private GameObject followObject;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MoveAgentToPoint(true);
            followObject = null;

        }

        if (Input.GetMouseButton(1))
        {
            MoveAgentToPoint(false);
        }

        if(followObject != null)
        {
            agent.destination = followObject.transform.position;
        }
    }

    void MoveAgentToPoint(bool isFollowMouse)
    {
        //Make a ray
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //hit info
        RaycastHit hitInfo;

        //Cast a ray
        if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        {
            if (isFollowMouse)
            {
                agent.destination = hitInfo.point;
            }
            else
            {
                followObject =  hitInfo.transform.gameObject;
                //We want to follow an object instead
            }
        }
    }
}
