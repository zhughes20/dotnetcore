using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetcore
{
    public partial class MyApp : Form
    {
        public MyApp()
        {
            InitializeComponent();
            // Creating and setting the properties of a label 
            Label l = new Label(); 
            l.AutoSize = true; 
            l.Text = "Would you like to submit your application?"; 
            l.Location = new Point(222, 145); 
            l.Font = new Font("French Script MT", 18); 
            // Adding this label to form 
            this.Controls.Add(l); 

            // Creating and setting the properties of Button 
            Button Submit_Button = new Button(); 
            Submit_Button.Location = new Point(225, 198); 
            Submit_Button.Text = "Submit"; 
            Submit_Button.AutoSize = true; 
            Submit_Button.BackColor = Color.LightBlue; 
            Submit_Button.Padding = new Padding(6); 
            Submit_Button.Font = new Font("French Script MT", 18); 
            Submit_Button.Click += Submit_Button_Click;
            // After you are finished adding properties to the submit button, add the button to the form 
            this.Controls.Add(Submit_Button); 
    
            // Creating and setting the properties of Button 
            Button Cancel_Button = new Button(); 
            Cancel_Button.Location = new Point(360, 198); 
            Cancel_Button.Text = "Cancel"; 
            Cancel_Button.AutoSize = true; 
            Cancel_Button.BackColor = Color.LightPink; 
            Cancel_Button.Padding = new Padding(6); 
            Cancel_Button.Font = new Font("French Script MT", 18); 
            Cancel_Button.Click += Cancel_Button_Click;
            // Adding this button to form 
            this.Controls.Add(Cancel_Button); 
        }
        //Method that occurs when the submit button is clicked, I just move the submit button on each click
        protected void Submit_Button_Click (object sender, EventArgs e){
            Button reference = sender as Button;
            reference.Location = new Point(reference.Location.X - 10, reference.Location.Y - 10);
        } 
        //Method that occurs when the cancel button is clicked, I move the submit button back to it's original position
        protected void Cancel_Button_Click (object sender, EventArgs e){
            Button reference = this.Controls[this.Controls.Count - 2] as Button;
            reference.Location = new Point(225, 198); 
        } 
    }
}
