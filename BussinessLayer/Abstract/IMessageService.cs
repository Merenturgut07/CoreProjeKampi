﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string p);
        List<Message> GetSendBoxListByWriter(string p);
    }
}
