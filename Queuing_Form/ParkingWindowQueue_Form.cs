using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queuing_Form
{
    public partial class ParkingWindowQueue_Form : Form
    {
        Parking_Class obj = new Parking_Class();

        public ParkingWindowQueue_Form()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = (1 * 100);
            timer.Tick += new EventHandler(Timer1_Tick);
            timer.Start();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayParkingQueue(Parking_Class.ParkingQueue);
        }

        public void DisplayParkingQueue(IEnumerable ParkingList)
        {
            listParkingQueue.Items.Clear();
            foreach (object obj in ParkingList)
            {
                listParkingQueue.Items.Add(obj.ToString());
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            //btnRefresh.PerformClick();
            DisplayParkingQueue(Parking_Class.ParkingQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Parking_Class.ParkingQueue.Dequeue();
        }
    }
}
