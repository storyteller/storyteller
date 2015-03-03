using System.Collections.Generic;
using System.Threading.Tasks;
using Storyteller.Core.Engine;
using Storyteller.Core.Grammars;
using Storyteller.Core.Model.Persistence;

namespace Storyteller.Core
{
    public interface IBatchObserver 
    {
        void SpecRequeued(SpecificationPlan plan, ISpecContext context);
        void SpecHandled(SpecificationPlan plan, ISpecContext context);

        Task<IEnumerable<BatchRecord>> MonitorBatch(IEnumerable<SpecNode> nodes);
    }
}