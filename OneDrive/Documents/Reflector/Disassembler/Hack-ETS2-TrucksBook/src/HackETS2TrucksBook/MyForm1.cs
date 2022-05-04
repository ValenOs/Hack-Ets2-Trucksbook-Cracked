namespace HackETS2TrucksBook
{
    using System;
    using System.ComponentModel;
    using System.Runtime.ExceptionServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class MyForm1 : Form
    {
        private TextBox txtLoginbook;
        private TextBox txtSenhabook;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Timer timer1;
        private IContainer components;
        private string connString;
        private string sql;

        public MyForm1();
        private void ~MyForm1();
        private void button1_Click(object sender, EventArgs e);
        private void detectagame();
        [HandleProcessCorruptedStateExceptions]
        protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);
        private void exibelogin();
        private void InitializeComponent();
        private void linkLabel1_Click(object sender, EventArgs e);
        private void MyForm1_Load(object sender, EventArgs e);
        private void timer1_Tick(object sender, EventArgs e);
        private void txtLogin_Click(object sender, EventArgs e);
        private void txtLogin_TextChanged(object sender, EventArgs e);
        private void txtSenha_Click(object sender, EventArgs e);
        private void txtSenha_TextChanged(object sender, EventArgs e);
    }
}

