using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jotter_App
{
    public partial class Form1 : Form
    {
        List<Notes> NotesList = null;
        public Form1()
        {
            this.NotesList = new List<Notes>();
            InitializeComponent();
        }

        

        private void Add_note_button_Click(object sender, EventArgs e)
        {
            Notes note = new Notes(this.textBoxTitle.Text, this.textBoxNote.Text);
            NotesList.Add(note);
        }
    }
}
