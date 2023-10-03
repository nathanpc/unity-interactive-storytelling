using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractiveStorytelling
{
    public class EnablingAction : BaseAction
    {
        public bool finalState = true;

        override public void PerfomAction()
        {
            gameObject.SetActive(finalState);
        }
    }
}