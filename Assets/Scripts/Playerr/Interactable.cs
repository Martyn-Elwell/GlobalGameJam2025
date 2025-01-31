using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour, IInteractable
{
    private LayerMask originalLayer;

    public void Start()
    {
        originalLayer = gameObject.layer;
        OnStart();
    }
    public virtual void OnStart()
    {

    }

    public virtual void Interact()
    {

    }

    public virtual void Interact(GameObject player)
    {
        Interact();
    }

    public void Outline(bool  active)
    {
        if (active)
        {
            gameObject.layer = LayerMask.NameToLayer("Outline");
            foreach (Transform child in transform.GetComponentsInChildren<Transform>())
            {
                transform.gameObject.layer = LayerMask.NameToLayer("Outline");
            }
        }
        else
        {
            gameObject.layer = originalLayer;
            foreach (Transform child in transform.GetComponentsInChildren<Transform>())
            {
                transform.gameObject.layer = originalLayer;
            }
        }
    }
}
