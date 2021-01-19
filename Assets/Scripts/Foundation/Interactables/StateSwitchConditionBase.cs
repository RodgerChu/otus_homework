using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateSwitchConditionBase : MonoBehaviour
{
    protected abstract void OnStateActivated();
    protected abstract void OnStateDisabled();
}
