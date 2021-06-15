using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SceneAction : MonoBehaviour
{
    [SerializeField] private BoxCollider2D Trigger = null;

    public abstract void Interact();

}
