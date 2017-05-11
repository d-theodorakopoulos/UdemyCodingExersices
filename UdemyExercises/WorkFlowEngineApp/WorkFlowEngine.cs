
namespace WorkFlowEngineApp
{
    public class WorkFlowEngine
    {
        private WorkFlow currentWorkflow;

        public WorkFlowEngine (WorkFlow workflow)
        {
            currentWorkflow = workflow;
        }

        public void Run()
        {
            foreach (var action in currentWorkflow.Actions)
            {
                action.Execute();
            }
        }
    }
}
