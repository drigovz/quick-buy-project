using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class BaseEntity
    {
        public List<string> _messageValidation { get; set; }

        private List<string> MessageValidation
        {
            get { return _messageValidation ?? (_messageValidation = new List<string>()); }
        }

        protected bool IsValid
        {
            get { return !MessageValidation.Any(); }
        }

        protected void ClearMessageValidation()
        {
            MessageValidation.Clear();
        }

        protected void AddMessageValidation(string message)
        {
            MessageValidation.Add(message);
        }

        public abstract void Validate();
    }
}
