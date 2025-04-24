using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOutline : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject border;
    void Start()
    {
        if (border != null)
        {
            border.SetActive(false);
        }
    }

    void OnMouseEnter()
    {
         if (border != null)
        {
            border.SetActive(true);
        }
    }



    void OnMouseExit() 
    {
        if (border != null)
        {
            border.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
