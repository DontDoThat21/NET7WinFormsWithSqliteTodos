﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET7WinFormsWithSqliteTodos.UI
{
    public partial class frmTodoDetail : Form
    {
        public frmTodoDetail()
        {
            InitializeComponent();
        }
        public void SetStatusButton(string status)
        {
            Button btn = new Button();
            switch (status)
            {
                case "all":
                    btnActive.BackColor = Color.FromName("Control");
                    btnCompleted.BackColor = Color.FromName("Control");
                    btn = btnAll;
                    break;
                case "active":
                    btnAll.BackColor = Color.FromName("Control");
                    btnCompleted.BackColor = Color.FromName("Control");
                    btn = btnActive;
                    break;
                case "completed":
                    btnAll.BackColor = Color.FromName("Control");
                    btnActive.BackColor = Color.FromName("Control");
                    btn = btnCompleted;
                    break;
                default:
                    break;
            }

            btn.BackColor = Color.FromName("ControlDark");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
