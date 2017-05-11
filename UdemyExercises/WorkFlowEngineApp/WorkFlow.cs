using System;
using System.Collections.Generic;

namespace WorkFlowEngineApp
{
    public class WorkFlow
    {
        public List<IAction> Actions { get;  set; }

        public WorkFlow ()
        {
            Actions = new List<IAction>();
        }

        public void AddAction(IAction action)
        {
            Actions.Add(action);
        }
    }
}
