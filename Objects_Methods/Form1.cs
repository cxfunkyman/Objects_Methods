using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objects_Methods.Business;

namespace Objects_Methods
{
    public partial class Form1 : Form
    {
        private Course oGradeRecord = new Course();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSetData_Click(object sender, EventArgs e)
        {
            oGradeRecord.SetStudentId(12345);
            oGradeRecord.SetFirstName("Maria");
            oGradeRecord.SetLastName("Ramirez");
            oGradeRecord.SetMidtermGrade(95.0f);
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string display = oGradeRecord.GetInfo(oGradeRecord);
            MessageBox.Show(display, "student record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelInfo.Text = oGradeRecord.GetInfo(oGradeRecord);
//            labelInfo.Text = display;
        }
    }
}
