using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetAllDeleted(string parameter)
        {
            return _messageDal.List(x => x.SenderMail == parameter || x.ReceiverMail==parameter).Where(x => x.Status == true).ToList();
        }

        public List<Message> GetAllDraft(string parameter)
        {
            return _messageDal.List(x => x.SenderMail == parameter).Where(y=>y.Draft==true && y.Status==false).ToList();
        }

        public List<Message> GetAllRead(string parameter)
        {
            return _messageDal.List(x => x.ReceiverMail == parameter).Where(x => x.IsRead == true && x.Status==false).ToList();
        }

        public List<Message> GetAllUnRead(string parameter)
        {
            return _messageDal.List(x => x.ReceiverMail == parameter).Where(x => x.IsRead == false && x.Status == false).ToList();
        }

        public Message GetByID(int id)
        {
            return _messageDal.Get(x=>x.MessageId==id);
        }

      

        public List<Message> GetListInbox(string parameter)
        {
            return _messageDal.List(x=>x.ReceiverMail==parameter).Where(x=>x.Status==false).ToList();
        }
        public List<Message> GetListInbox(string parameter,string contain)
        {
            return _messageDal.List(x => x.ReceiverMail == parameter).Where(x => x.Status == false && (x.MessageContent.Contains(contain)||x.SenderMail.Contains(contain)||x.Subject.Contains(contain))).ToList();
        }

        public List<Message> GetListSendbox(string parameter)
        {
            return _messageDal.List(x => x.SenderMail==parameter).Where(x=> x.Draft==false && x.Status == false).ToList();
        }

       

        public void MessageAddBL(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MessageDelete(Message message)
        {         
            _messageDal.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            _messageDal.Update(message);
        }
    }
}
