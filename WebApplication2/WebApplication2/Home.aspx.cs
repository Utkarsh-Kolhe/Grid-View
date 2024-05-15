//using System;
//using System.Collections.Generic;

//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace WebApplication2
//{
//    class Demo
//    {
//        public string S_No { get; set; }
//        public string Investigation {  get; set; }
//        public string Marks { get; set;}
//    }
//    public partial class Home : System.Web.UI.Page
//    {
//        static List<Demo> lst = new List<Demo>();
//        static int count = 0;
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            GrideViewTable();
//        }

//        protected void AddToGridButton_Click(object sender, EventArgs e)
//        {
//            Demo demo = new Demo();
//            demo.S_No = (++count).ToString();
//            demo.Investigation = InvestigationDropDownList.Text;
//            demo.Marks = MarksTextBox.Text;

//            lst.Add(demo);

//            GrideViewTable();
//        }

//        public void GrideViewTable()
//        {
//            GridView1.DataSource = lst;
//            GridView1.DataBind();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    class Demo
    {
        public string S_No { get; set; }
        public string Investigation { get; set; }
        public string Marks { get; set; }
    }
    public partial class Home : System.Web.UI.Page
    {
        static List<Demo> lst = new List<Demo>();
        static int count = 0;
        static int editIndex = -1; // Track the index of the row being edited

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GrideViewTable();
            }
        }

        protected void AddToGridButton_Click(object sender, EventArgs e)
        {
            Demo demo = new Demo();
            if (editIndex != -1) // Check if editing
            {
                demo = lst[editIndex];
                demo.Investigation = InvestigationDropDownList.Text;
                demo.Marks = MarksTextBox.Text;
                lst[editIndex] = demo;
                editIndex = -1; // Reset edit index
            }
            else
            {
                demo.S_No = (++count).ToString();
                demo.Investigation = InvestigationDropDownList.Text;
                demo.Marks = MarksTextBox.Text;
                lst.Add(demo);
            }
            GrideViewTable();
            ClearFields();
        }

        protected void ClearFields()
        {
            InvestigationDropDownList.SelectedIndex = 0;
            MarksTextBox.Text = "";
        }

        public void GrideViewTable()
        {
            GridView1.DataSource = lst;
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Create the Edit button
                Button btnEdit = new Button();
                btnEdit.CommandName = "Edit";
                btnEdit.Text = "Edit";
                btnEdit.CssClass = "btn btn-primary";
                btnEdit.CommandArgument = e.Row.RowIndex.ToString();
                btnEdit.Click += new EventHandler(btnEdit_Click);

                // Create the Delete button
                Button btnDelete = new Button();
                btnDelete.CommandName = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.CssClass = "btn btn-danger";
                btnDelete.CommandArgument = e.Row.RowIndex.ToString();
                btnDelete.Click += new EventHandler(btnDelete_Click);

                // Add buttons to the GridView
                e.Row.Cells[3].Controls.Add(btnEdit); // Assuming the edit column is at index 3
                e.Row.Cells[3].Controls.Add(btnDelete); // Assuming the delete column is at index 3
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            editIndex = int.Parse(btn.CommandArgument);
            Demo demo = lst[editIndex];
            InvestigationDropDownList.Text = demo.Investigation;
            MarksTextBox.Text = demo.Marks;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int rowIndex = int.Parse(btn.CommandArgument);
            lst.RemoveAt(rowIndex);
            GrideViewTable();
        }
    }
}
