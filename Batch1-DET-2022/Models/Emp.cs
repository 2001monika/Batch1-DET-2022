using System;
using System.Collections.Generic;

namespace Batch1_DET_2022.Models
{
    public partial class Emp
    {
        internal int empno;
        internal int deptno;

        public Emp()
        {
            InverseMgrNavigation = new HashSet<Emp>();
        }

        public int Empno { get; set; }
        public int EMPNO { get; internal set; }
        public string? Ename { get; set; }
        public string ENAME { get; internal set; }
        public string? Job { get; set; }
        public string JOB { get; internal set; }
        public int? Mgr { get; set; }
        public DateTime? Hiredate { get; set; }
        public int? Sal { get; set; }
        public int SAL { get; internal set; }
        public int? Comm { get; set; }
        public int Deptno { get; set; }
        public int DEPTNO { get; internal set; }
        public virtual Emp? MgrNavigation { get; set; }
        public virtual ICollection<Emp> InverseMgrNavigation { get; set; }
    }
}
