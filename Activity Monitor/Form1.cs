using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Principal;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Activity_Monitor
{
    public partial class mainForm : Form
    {
        GlobalKeyboardHook gHook;


        string userName;
        public mainForm()
        {
            InitializeComponent();
            
            //Save the name of Currently Logged in User in a String Variable.
            userName = Environment.UserName;

            // Create a new GlobalKeyboardHook
           
        
    }

        private void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = 10.ToString();
        }

        private void btnName_Click(object sender, EventArgs e)
        {



        }



        private void mainForm_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook();

            // Declare a KeyDown Event
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            // Add the keys you want to hook to the HookedKeys list
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            { 
                gHook.HookedKeys.Add(key);
            }
            gHook.hook(); 
        }

        
    }
}
