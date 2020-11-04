using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform playerTransform;
    public float moveSpeed = 1; 

    private void OnEnable()
    {
        if(playerTransform==null)
        {
            playerTransform= GameObject.FindGameObjectWithTag("Player").transform;

        }

        MoveToPlayer();
    }
   
    void MoveToPlayer()
    {
        GetComponent<Rigidbody2D>().DOMove(playerTransform.position, 1 / moveSpeed).OnComplete(PathFinish);
    }

    void PathFinish()
    {
        
    }
}
