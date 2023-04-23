namespace hackathon_21._04._23
{
    /// <summary>
    /// Процесс, результатом которого является КЦП
    /// </summary>
    public class Process:BaseEntity
    {
        /// <summary>
        /// Перечень дочерних процессов, 
        /// </summary>
        public List<Process> ChildProcesses { get; set; }

        /// <summary>
        /// Перечень зависимых процессов, которые нужно уведомить о том, что 
        /// </summary>
        public List<Process> ParentProcesses { get; set; }

        /// <summary>
        /// Входящие ресурсы
        /// </summary>
        public List<Resource> IncomingResources { get; set; }
        /// <summary>
        /// Исходящие ресурсы
        /// </summary>
        public List<Resource> OutcomingResources { get; set; }

        /// <summary>
        /// Исполнители
        /// </summary>
        public List<Performer> Performers { get; set; }

        /// <summary>
        /// Признаки
        /// </summary>
        public List<Sign> Signs { get; set; }   


        public Process() 
        {

        }


        public void AddChildProcess()
        {

        }

        public void RemoveChildProcess()
        {

        }

        public void AddParentProcess() { }
        public void RemoveParentProcess() { }
        public void AddIncomingResources() { }
        public void RemoveIncomingResources() { }
        public void AddOutgoingResources() { }
        public void RemoveOutgoingResources() { }
        public void AddResource(Resource resource) { }
        public void RemoveResource(Resource resource) { }
 



    }
}
