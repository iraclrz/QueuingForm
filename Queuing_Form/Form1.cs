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
    public partial class Queuing_Form : Form
    {
        private Parking_Class parking = new Parking_Class();
        public Queuing_Form()
        {
            InitializeComponent();
            parking = new Parking_Class();
            ParkingWindowQueue_Form obj = new ParkingWindowQueue_Form();
            obj.Show();

        }

        private void btnParking_Click(object sender, EventArgs e)
        {
            lblQueue.Text = parking.ParkingGeneratedNumber("ISK - ");
            Parking_Class.getNumberInQueue = lblQueue.Text;

            Parking_Class.ParkingQueue.Enqueue(Parking_Class.getNumberInQueue);

        }


    }
}
