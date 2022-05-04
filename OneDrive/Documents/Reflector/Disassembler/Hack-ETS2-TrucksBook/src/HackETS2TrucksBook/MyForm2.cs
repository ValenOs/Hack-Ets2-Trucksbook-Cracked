namespace HackETS2TrucksBook
{
    using System;
    using System.ComponentModel;
    using System.Runtime.ExceptionServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class MyForm2 : Form
    {
        private TextBox txtSenhabook;
        private TextBox txtLoginbook;
        private Button button2;
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Container components;
        private string connString;
        private string sql;

        public MyForm2();
        private void ~MyForm2();
        private void button2_Click(object sender, EventArgs e);
        [HandleProcessCorruptedStateExceptions]
        protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);
        private void InitializeComponent();
        private void MyForm2_Load(object sender, EventArgs e);
    }
}

