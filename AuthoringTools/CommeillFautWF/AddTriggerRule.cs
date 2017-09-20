﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommeillFaut.DTOs;
using CommeillFautWF.ViewModels;
using CommeillFaut;
using Equin.ApplicationFramework;



namespace CommeillFautWF
{
    public partial class AddTriggerRule : Form
    {

        private TriggerRulesDTO dto;
        public ObjectView<TriggerRulesDTO> AddedObject { get; private set; } = null;

        public TriggerRulesVM Vm { get; private set; }

        public AddTriggerRule(TriggerRulesVM vm)
        {
            Vm = vm;
            InitializeComponent();
        }


        public AddTriggerRule(TriggerRulesVM vm, TriggerRulesDTO trig)
        {
            dto = trig;
            Vm = vm;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void AddTriggerRule_Load(object sender, EventArgs e)
        {

        }


       
    }
}
