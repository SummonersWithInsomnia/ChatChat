using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatChat
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

            TreeNode myContactNode = new TreeNode("My Contacts");
            TreeNode friend1 = new TreeNode("Friend 1");
            TreeNode friend2 = new TreeNode("Friend 2");
            TreeNode friend3 = new TreeNode("Friend 3");
            
            myContactNode.Nodes.Add(friend1);
            myContactNode.Nodes.Add(friend2);
            myContactNode.Nodes.Add(friend3);
            
            treeView.Nodes.Add(myContactNode);
        }
    }
}