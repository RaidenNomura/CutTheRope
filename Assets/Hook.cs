using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    #region Exposed

    [SerializeField] GameObject linkPrefab;
    [SerializeField] int links;

    #endregion

    #region Unity Lifecycle
    
    void Start()
    {
        Rigidbody2D prevLinkRB = GetComponent<Rigidbody2D>();
        for (int i = 0; i < links; i++)
        {
            GameObject link = Instantiate(linkPrefab, transform);
            link.GetComponent<HingeJoint2D>().connectedBody = (i == 0) ? GetComponent<Rigidbody2D>() : prevLinkRB;
            prevLinkRB = link.GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        
    }

    #endregion

    #region Methods



    #endregion

    #region Private & Protected

   

    #endregion
}
