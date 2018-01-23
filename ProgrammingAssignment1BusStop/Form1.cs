using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment1BusStop
{
    public partial class Form1 : Form
    {
        // Glabal variables
        private BusCalculations busCalculations = BusCalculations.Instance;
        // Create an instance of a class ResetComponents
        private ResetComponents resetComponents = ResetComponents.Instance;
        // Create an instance of the class validate fields
        ValidateFields validateFields = ValidateFields.Instance;
        private float travelTime = 0f;
        private float travelDistance = 0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void travelDistanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Send the travel time text to validator
                if (validateFields.ValidateTravelTimeTextBox(travelTimeTextBox))
                {
                    busCalculations.TravelTime = float.Parse(travelTimeTextBox.Text);
                    busCalculations.CalculateDistance(busCalculations.TravelTime);
                    travelDistanceResultTextBox.Text = busCalculations.TravelDistance.ToString("N2");
                }
                else
                {
                    // Clear all the text
                    resetComponents.ResetTravelTimeTextBox(travelTimeTextBox);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void travelTimeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Send the travel disntance text to validator
                if (validateFields.ValidateTravelTimeTextBox(travelDistanceTextBox))
                {
                    busCalculations.TravelDistance = float.Parse(travelDistanceTextBox.Text);
                    busCalculations.CalculateTime(busCalculations.TravelDistance);
                    travelTimeResultTextBox.Text = busCalculations.TravelTime.ToString("N2");
                }
                else
                {
                    // Clear all the text
                    resetComponents.ResetTravelTimeTextBox(travelTimeTextBox);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
