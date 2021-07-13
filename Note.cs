using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotter_App
{
    class Notes
    {
        string title;
        string note;

        public string Title { get => title; set => title = value; }
        public string Note { get => note; set => note = value; }

        public Notes(string title, string note)
        {
            this.title = title;
            this.note = note;
        }
    }
}
