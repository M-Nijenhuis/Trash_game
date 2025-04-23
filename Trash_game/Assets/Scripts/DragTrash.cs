using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DragTrash : MonoBehaviour
{
    private bool isBeingDragged = false;
    private Camera cam;
    private MovingTrash movingTrash;

    private void Start()
    {
        cam = Camera.main;
        movingTrash = GetComponent<MovingTrash>();
    }

    private void Update()
    {
        if (isBeingDragged)
        {
            Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;

            if (Input.GetMouseButtonDown(0))
            {
                TryDrop();
            }
        }
    }

    private void OnMouseDown()
    {
        if (!isBeingDragged)
        {
            isBeingDragged = true;

            if (movingTrash != null)
            {
                movingTrash.canMove = false;
            }
        }
    }

    private void CheckTrashType(string colliderTag)
    {
        string currentTrashType = gameObject.tag;
        if (colliderTag == currentTrashType)
        {   
            Debug.Log("The tag is good");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("The tag is NOT Good");
        }
    }

    private void TryDrop()
    {
        Collider2D myCollider = GetComponent<Collider2D>();
        if (myCollider != null) myCollider.enabled = false;

        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

        if (myCollider != null) myCollider.enabled = true;

        if (hit.collider != null)
        {
            Debug.Log("Clicked on: " + hit.collider.gameObject.name + ", Tag: " + hit.collider.tag);

            CheckTrashType(hit.collider.tag);
        }
        else
        {
            Debug.Log("Nothing hit. Still dragging.");
        } 
    }

}