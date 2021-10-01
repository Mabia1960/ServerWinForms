using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TestDateTime
{
    public partial class Form1 : Form
    {
        //на форме listbox, textbox button
        // listbox принимаем от клиентов listbox1 
        // textbox посылаем клиентам textbox1
        Server _server; //экземпляр класса
        public Form1()
        {
            
            InitializeComponent();            
        }       
        private void Form1_Load(object sender, EventArgs e)
        {
            //старт сервера
            Thread t = new Thread(delegate ()
            {
                _server = new Server("127.0.0.1", 9099);               
            });
            t.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // как получить из класса принятое от клиентов сообщение и записать в листбокс?
            // как послать клиентам сообщение из текстбокса?
        }        
    }
}