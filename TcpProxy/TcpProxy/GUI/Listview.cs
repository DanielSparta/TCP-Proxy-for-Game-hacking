using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcpProxy.GUI;

namespace TcpProxy.GUI
{
    public class Listview
    {
        public static void AddItem(string value, string substring, TcpProxy GUIform)
        {
            ListViewItem item = new ListViewItem(value);
            item.SubItems.Add(substring);
            GUIform.Invoke((MethodInvoker)delegate { GUIform.PacketList.Items.Add(item); });
        }
    }
}
