using WebApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Business
{
    public interface IAttachmentService
    {
        Task<Attachment> GetById(Guid id);
        void Deletes(List<Guid> ids);
        void Delete(Guid id);
    }
}