using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var c=new Context())
            {
                return c.message2s.Include(x=>x.SenderUser).Where(x=>x.ReceiverId==id).ToList();
            }
        }

        public List<Message2> GetSendBoxListWithMessageByWriter(int id)
        {
            using (var c=new Context())
            {
                return c.message2s.Include(x => x.ReceiverUser).Where(y => y.SenderId == id).ToList();
            }
        }
    }
}
