using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FluentData;


namespace ConnectDBIP
{
    public partial class Form1 : Form
    {
        private IDbContext _context;
        //private static string _dbLink = @"server=192.168.1.107;Database=School;uid=sa;pwd=ming520";
        private static string source = "database=School;Server=fe80::b877:e7b2:4ac7:4ed3%3,1433;User ID=sa;Password=ming520;Persist Security Info=True";
        public Form1()
        {     
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _context = new DbContext().ConnectionString(source,new SqlServerProvider());
            if(_context!=null)
                MessageBox.Show("连接数据库成功！");
           else
                MessageBox.Show("连接数据库失败！");


            string sql = "select * from T_Test";
            List<Test> text = _context.Sql(sql).QueryMany<Test>();

            dataGridView1.DataSource = text;

        }
    }
}
