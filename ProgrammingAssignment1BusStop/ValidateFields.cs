using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment1BusStop
{
    /// <summary>
    /// Validates that the text entered is correct
    /// </summary>
    public sealed class ValidateFields
    {
        #region Fields
        private bool travelTimeTextBoxValidated = false;
        private bool travelDistanceTextBoxValidated = false;
        float travelTime = 0f;
        // Singleton fields
        private static volatile ValidateFields instance;
        private static object syncRoot = new object();
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor
        /// </summary>
        private ValidateFields() { }

        #endregion

        #region Properties
        /// <summary>
        /// Singleton implementation
        /// </summary>
        public static ValidateFields Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ValidateFields();
                    }
                }
                return instance;
            }
        }
        public bool TravelTimeTextBoxValidated { get; set; }
        public bool TravelDistanceTextBoxValidated { get; set; }
        #endregion

        #region Methods
        public bool ValidateTravelTimeTextBox(TextBox travelTimeTextBox)
        {
            try
            {
                // Check if the user entered any text
                if (travelTimeTextBox.Text != "")
                {
                    if (float.TryParse(travelTimeTextBox.Text, out travelTime))
                    {
                        // MessageBox.Show("This is a change to demo GIT");
                    }
                    else
                    {
                        MessageBox.Show("Enter number text only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }  
                }
                else
                {
                    MessageBox.Show("Enter travel time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
