using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Ado.Entities
{
    public class Award
    {
        public string ID { get; set; }
        public string Title { get; set; }

        public Award(string title)
        {
            Title = title;
        }

        public Award(string id, string title)
        {
            this.ID = id;
            Title = title;
        }
    }
}
