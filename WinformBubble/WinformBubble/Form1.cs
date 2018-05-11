using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformBubble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当前消息气泡起始位置
        /// </summary>
        private int top = 0;

        /// <summary>
        /// 当前消息气泡高度
        /// </summary>
        private int height = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            AddSendMessage(textBox1.Text);
            AddReceiveMessage(textBox1.Text);
        }

        /// <summary>
        /// 显示接收消息
        /// </summary>
        /// <param name="model"></param>
        private void AddReceiveMessage(string content)
        {
            Item item = new Item();
            item.messageType = WinformBubble.Item.MessageType.receive;
            item.SetWeChatContent(content);

            //计算高度
            item.Top = top + height;
            top = item.Top;
            height = item.HEIGHT;

            //滚动条移动最上方，重新计算气泡在panel的位置
            panel1.AutoScrollPosition = new Point(0, 0);
            panel1.Controls.Add(item);
        }

        // <summary>
        /// 更新界面，显示发送消息
        /// </summary>
        private void AddSendMessage(string content)
        {
            Item item = new Item();
            item.messageType = WinformBubble.Item.MessageType.send;
            item.SetWeChatContent(content);
            item.Top = top + height;
            item.Left = 370 - item.WIDTH;

            top = item.Top;
            height = item.HEIGHT;
            panel1.AutoScrollPosition = new Point(0, 0);
            panel1.Controls.Add(item);
        }
    }
}
