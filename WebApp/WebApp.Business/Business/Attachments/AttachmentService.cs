using WebApp.Business.RepositoryBase;
using WebApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity.Attributes;

namespace WebApp.Business
{
    public class AttachmentService : IAttachmentService
    {
        #region Attributes

        private readonly IDbContextScopeFactory _dbContextScopeFactory;
        private readonly IAttachmentRepository _attachmentRepository;
        #endregion
        public AttachmentService(
            IDbContextScopeFactory dbContextScopeFactory,
            IAttachmentRepository attachmentRepository)
        {
            _dbContextScopeFactory = dbContextScopeFactory;
            _attachmentRepository = attachmentRepository;
        }
        
        public async Task<Attachment> GetById(Guid id)
        {
            using (var dbContextReadOnlyScope = _dbContextScopeFactory.CreateReadOnly())
            {
                return await _attachmentRepository.FindAsync(x => x.Id == id);
            }
        }
        public async void Deletes(List<Guid> ids)
        {
            using (var dbContextReadOnlyScope = _dbContextScopeFactory.Create())
            {
                foreach (var id in ids)
                {
                    var attchment = _attachmentRepository.GetById(id);

                    _attachmentRepository.Delete(attchment);
                }
                await dbContextReadOnlyScope.SaveChangesAsync();
            }
        }
        public async void Delete(Guid id)
        {
            using (var dbContextReadOnlyScope = _dbContextScopeFactory.Create())
            {
                var attchment = _attachmentRepository.GetById(id);

                _attachmentRepository.Delete(attchment);
                await dbContextReadOnlyScope.SaveChangesAsync();
            }
        }
    }
}