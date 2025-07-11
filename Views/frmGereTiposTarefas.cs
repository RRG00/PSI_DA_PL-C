﻿using iTasks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks
{
    public partial class frmGereTiposTarefas : Form
    {
        private ITaskContext ItaskContext;
        public frmGereTiposTarefas()
        {
            InitializeComponent();
            ItaskContext = new ITaskContext();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            using (var ItaskContext = new ITaskContext())
            {
                string Name = txtDesc.Text;
                TypeTask typeTask = new TypeTask(Name);
                ItaskContext.TipeTasks.Add(typeTask);
                ItaskContext.SaveChanges();

                txtId.Text = FindAvailableID().ToString();

                UpdateFields();
                
            }
        }
        public void UpdateFields()
        {
            using (var ItaskContext = new ITaskContext())
            {
                lstLista.DataSource = ItaskContext.TipeTasks.ToList();
            }
        }
        public void UpdateTypeTaskList()
        {
            using (var ItaskContext = new ITaskContext())
            {
                lstLista.DataSource = null;
                lstLista.DataSource = ItaskContext.TipeTasks.ToList();
            }
        }
        public int FindAvailableID()
        {
            using (var ItaskContext = new ITaskContext())
            {
                return ItaskContext.TipeTasks.Select(e => e.Id).DefaultIfEmpty(0).Max() + 1;
            }
        }

    }
}
