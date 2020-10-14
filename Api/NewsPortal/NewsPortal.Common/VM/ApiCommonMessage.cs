using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Common.VM
{
    public class ApiCommonMessage
    {

        public string UserName { get; set; }
        public string Token { get; set; }
        public string FormName { get; set; }
        public string ModuleName { get; set; }
        public string Content { get; set; }


        public TEntity GetRequestObject<TEntity>() where TEntity : class
        {
            if (string.IsNullOrEmpty(this.Content))
            {
                throw new ArgumentNullException("Content is null or empty");
            }

            return JsonConvert.DeserializeObject<TEntity>(this.Content);
        }
    }
}
