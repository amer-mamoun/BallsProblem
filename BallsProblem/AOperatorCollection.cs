using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsProblem
{
    abstract class AOperatorCollection : IEnumerable<IOperator>
    {
        protected List<IOperator> operatorList;

        protected abstract void init();

        public AOperatorCollection()
        {
            operatorList = new List<IOperator>();
            init();
        }


        public IEnumerator<IOperator> GetEnumerator()
        {
            return operatorList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
