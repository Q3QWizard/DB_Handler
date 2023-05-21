using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Handler
{
    public partial class Form1 : Form
    {
        private DB_Handler_MSS _DB_Handler_MSS;
        public Form1()
        {
            InitializeComponent();

            _DB_Handler_MSS = new DB_Handler_MSS();
        }

        private void Btn_Select_Query_Click(object sender, EventArgs e)
        {
           DataSet ds = _DB_Handler_MSS.GetDataSet("select * from Department;");
        }

        private void Btn_Select_Query_Where_Click(object sender, EventArgs e)
        {
            List<QueryParam> mSS_Query_Objects = new List<QueryParam>();
            mSS_Query_Objects.Add(new QueryParam() { Param = "@Id", ParamValue = 1, ParamSqlDBType = SqlDbType.Int });
            _DB_Handler_MSS.GetDataSet("select * from Department where Id = @Id", mSS_Query_Objects);
        }

        private void Btn_Insert_Query_Click(object sender, EventArgs e)
        {
            List<QueryParam> mSS_Query_Objects = new List<QueryParam>();
            mSS_Query_Objects.Add(new QueryParam() { Param = "@Dep_Name", ParamValue = "test_dep", ParamSqlDBType = SqlDbType.NVarChar });
            mSS_Query_Objects.Add(new QueryParam() { Param = "@Dep_Desc", ParamValue = "teset", ParamSqlDBType = SqlDbType.NVarChar });
            _DB_Handler_MSS.ExecuteNonQuery("INSERT INTO Department (Dep_Name, Dep_Desc) VALUES (@Dep_Name, @Dep_Desc);", mSS_Query_Objects);
        }
    }
}
