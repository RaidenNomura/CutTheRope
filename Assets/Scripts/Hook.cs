using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    #region Exposed

    [SerializeField] GameObject linkPrefab;
    [SerializeField] int links;
    [SerializeField] GameObject connectedObject;

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
            if (i == links - 1)
            {
                SetConnectedObject(connectedObject, prevLinkRB);
            }
        }
    }

    void Update()
    {

    }

    #endregion

    #region Methods

    void SetConnectedObject(GameObject obj, Rigidbody2D rb)
    {
        HingeJoint2D hingeJoint = obj.AddComponent<HingeJoint2D>();

        hingeJoint.connectedBody = rb;
        hingeJoint.autoConfigureConnectedAnchor = false;
        hingeJoint.anchor = Vector2.zero;
        hingeJoint.connectedAnchor = Vector2.zero;
    }

    #endregion

    #region Private & Protected

    private GameObject lastLink;

    #endregion
}
