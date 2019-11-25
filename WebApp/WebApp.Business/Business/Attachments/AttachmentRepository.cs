using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApp.DataAccess;
using WebApp.Business.RepositoryBase;
using Unity.Attributes;

namespace WebApp.Business
{
    public class AttachmentRepository : Repository<WebAppContext, Attachment>, IAttachmentRepository
    {
        public AttachmentRepository(IAmbientDbContextLocator ambientDbContextLocator) : base(ambientDbContextLocator)
        {
        }
        
        public Attachment GetById(object id)
        {
            var guidId = Guid.Parse(id.ToString());
            return DbSet.FirstOrDefault(x => x.Id == guidId);
        }
    }
}