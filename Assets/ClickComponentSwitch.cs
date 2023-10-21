using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickComponentSwitch : MonoBehaviour
{
    [SerializeField] Behaviour component;

    private void OnMouseDown()
    {
        component.enabled = !component.enabled;
    }
}
