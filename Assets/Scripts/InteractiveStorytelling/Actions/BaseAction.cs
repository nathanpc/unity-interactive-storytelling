using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractiveStorytelling
{
    /// <summary>
    /// Base action that all actions Components must inherit from.
    /// </summary>
    public class BaseAction : MonoBehaviour, IAction
    {
        virtual public void PerfomAction()
        {
            // REMEMBER TO USE OVERRIDE IN THE INHERITED CLASS. :)
            throw new System.NotImplementedException();
        }
    }
}
