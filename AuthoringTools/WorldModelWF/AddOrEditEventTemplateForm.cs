﻿using AutobiographicMemory;
using Conditions.DTOs;
using EmotionalAppraisal.DTOs;
using System;
using System.Windows.Forms;
using WellFormedNames;
using WorldModelWF.Properties;

namespace WorldModelWF
{
    public partial class AddOrEditEventTemplateForm : Form
    {
      //  private AppraisalRulesVM _appraisalRulesVM;
        private AppraisalRuleDTO _appraisalRuleToEdit;

        public AddOrEditEventTemplateForm(AppraisalRuleDTO ruleToEdit = null)
        {
            InitializeComponent();

        //    _appraisalRulesVM = ruleVM;
            _appraisalRuleToEdit = ruleToEdit;

            //validationRules
            textBoxSubject.AllowNil = false;
            textBoxSubject.AllowComposedName = false;
            textBoxDesirability.OnlyIntOrVariable = true;
            textBoxPraiseworthiness.OnlyIntOrVariable = true;

            //defaultValues
            textBoxSubject.Value = WellFormedNames.Name.UNIVERSAL_SYMBOL;
            textBoxObject.Value = WellFormedNames.Name.UNIVERSAL_SYMBOL;
            textBoxTarget.Value = WellFormedNames.Name.UNIVERSAL_SYMBOL;
            textBoxDesirability.Value = WellFormedNames.Name.BuildName("0");
            textBoxPraiseworthiness.Value = WellFormedNames.Name.BuildName("0");
     //       comboBoxEventType.DataSource = AppraisalRulesVM.EventTypes;

            if (ruleToEdit != null)
            {
                this.Text = "Update";
                this.addOrEditButton.Text = "Update";
                comboBoxEventType.Text = ruleToEdit.EventMatchingTemplate.GetNTerm(1).ToString();
                textBoxSubject.Value = ruleToEdit.EventMatchingTemplate.GetNTerm(2);
                textBoxObject.Value = ruleToEdit.EventMatchingTemplate.GetNTerm(3);
                textBoxTarget.Value = ruleToEdit.EventMatchingTemplate.GetNTerm(4);
                textBoxDesirability.Value = ruleToEdit.Desirability;
                textBoxPraiseworthiness.Value = ruleToEdit.Praiseworthiness;
            }
        }

        private void addOrEditButton_Click_1(object sender, EventArgs e)
        {
            AppraisalRuleDTO newRule = new AppraisalRuleDTO();
            try
            {
                newRule = new AppraisalRuleDTO()
                {
                    EventMatchingTemplate = WellFormedNames.Name.BuildName(
                    (Name)AMConsts.EVENT, 
                    (Name)comboBoxEventType.Text,
                    textBoxSubject.Value,
                    textBoxObject.Value,
                    textBoxTarget.Value),
                    Desirability = textBoxDesirability.Value,
                    Praiseworthiness = textBoxPraiseworthiness.Value,
                    Conditions = new ConditionSetDTO()
                };
           
                if (_appraisalRuleToEdit != null)
                {
                    newRule.Id = _appraisalRuleToEdit.Id;
                    newRule.Conditions = _appraisalRuleToEdit.Conditions;
                }
 //               _appraisalRulesVM.AddOrUpdateAppraisalRule(newRule);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void labelObject_Click(object sender, EventArgs e)
        {

        }

        private void AddOrEditAppraisalRuleForm_Load(object sender, EventArgs e)
        {

        }

        private void AddOrEditAppraisalRuleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}