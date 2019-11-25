using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.DataAccess;
using WebApp.Business.RepositoryBase;

namespace WebApp.Business
{ 
    public interface IAttachmentRepository: IRepository<Attachment>
    {
        Attachment GetById(object id);
    }
}