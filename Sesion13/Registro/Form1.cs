﻿using Registro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
   public partial class Form1 : Form
   {
      List<Person> persons;
      public Form1()
      {
         InitializeComponent();
         persons = new List<Person>();
      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
         Person person = new Person();
         person.Firstname = tbFirstName.Text;
         person.Lastname = tbLastName.Text;
         person.Birthdate = dtpBirthdate.Value; 
         persons.Add(person);
         ShowPerson();
         ClearTb();
      }
      private void ShowPerson()
      {
         dgvPersons.DataSource = null;
         dgvPersons.DataSource = persons;
      }
      private void ClearTb()
      {
         tbFirstName.Clear();
         tbLastName.Clear();
         dtpBirthdate.Value = DateTime.Now;
         tbFirstName.Focus();
      }
   }
}
